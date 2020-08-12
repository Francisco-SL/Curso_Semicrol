using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQL_1.Clases
{
    class LineaFacturaAR
    {
        public LineaFacturaAR(int numero, FacturaActiveRecord factura, string producto, int unidades)
        {
            Numero = numero;
            Factura = factura;
            Producto = producto;
            Unidades = unidades;
        }

        public int Numero { get; set; }
        public FacturaActiveRecord Factura { get; set; }
        public string Producto { get; set; }
        public int Unidades { get; set; }

        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        public override string ToString() => "Linea: " + Numero + "\tProducto: " + Producto + "\tUnidades: " + Unidades;

        public static List<LineaFacturaAR> BuscarTodos()
        {
            string query = "SELECT Factura.Numero, Factura.Concepto, LineasFactura.Numero, " +
                "Producto.Nombre, LineasFactura.Unidades FROM LineasFactura INNER JOIN Factura ON Factura.Numero=LineasFactura.Factura_Numero INNER JOIN Producto ON Producto.Numero=LineasFactura.Producto_Numero";
            List<LineaFacturaAR> list = new List<LineaFacturaAR>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new LineaFacturaAR(reader.GetInt32(2), new FacturaActiveRecord(reader.GetInt32(0), reader.GetString(1)), reader.GetString(3), reader.GetInt32(4)));
                    }
                    reader.Close();
                }
                return list;
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
                return null;
            }
        }

        public static List<FacturaActiveRecord> BuscarTodos(FiltroFactura f)
        {
            string query = "SELECT * FROM Factura";
            List<FacturaActiveRecord> list = new List<FacturaActiveRecord>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(FacturaActiveRecord.CadenaConexion))
                {
                    SqlCommand comando = new SqlCommand();
                    conexion.Open();
                    if (f.Numero != 0)
                    {
                        query += " WHERE Numero = @prNum";
                        comando.Parameters.Add(new SqlParameter("@prNum", f.Numero));
                        if (f.Concepto != null)
                        {
                            query += " AND Concepto = @prCon";
                            comando.Parameters.Add(new SqlParameter("@prCon", f.Concepto));
                        }
                    }
                    else if (f.Concepto != null)
                    {
                        query += " WHERE Concepto = @prCon";
                        comando.Parameters.Add(new SqlParameter("@prCon", f.Concepto));
                    }
                    comando.CommandText = query;
                    comando.Connection = conexion;
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new FacturaActiveRecord(Convert.ToInt32(reader["Numero"]), Convert.ToString(reader["Concepto"])));
                    }
                    reader.Close();
                }
                return list;
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
                return null;
            }
        }

        public void Insertar()
        {
            string query = "INSERT INTO LineasFactura VALUES (@prNumero, (SELECT Factura.Numero FROM Factura WHERE Factura.Numero=@prNumFac), (SELECT Numero FROM Producto WHERE Producto.Nombre=@prProdNombre), @prUnidades)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNumero", Numero));
                    comando.Parameters.Add(new SqlParameter("@prUnidades", Unidades));
                    comando.Parameters.Add(new SqlParameter("@prNumFac", Factura.Numero));
                    comando.Parameters.Add(new SqlParameter("@prProdNombre", Producto));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} ingresada en la BBDD", ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public static List<LineaFacturaAR> LineasDeFactura(FacturaActiveRecord f)
        {
            List<LineaFacturaAR> list = new List<LineaFacturaAR>();
            string query = "SELECT LineasFactura.Numero, Producto.Nombre, LineasFactura.Unidades, Factura.Concepto FROM LineasFactura INNER JOIN Producto ON Producto.Numero = LineasFactura.Producto_Numero INNER JOIN Factura ON Factura.Numero = LineasFactura.Factura_numero WHERE Factura.Numero = @prNumeroFactura ORDER BY LineasFactura.Numero ASC";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNumeroFactura", f.Numero));
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new LineaFacturaAR(reader.GetInt32(0), new FacturaActiveRecord(f.Numero, reader.GetString(3)), reader.GetString(1), reader.GetInt32(2)));
                        f.Concepto = reader.GetString(3);
                    }
                }
                return list;
            }
            catch (SqlException e)
            {
                Console.WriteLine("EROR SQL: {0}", e.Message);
                return null;
            }
        }
    }
}
