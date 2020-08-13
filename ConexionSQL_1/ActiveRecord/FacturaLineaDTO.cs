using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQL_1
{
    class FacturaLineaDTO
    {
        public FacturaLineaDTO(int numeroFactura, string concepto, int unidades, int productoID)
        {
            NumeroFactura = numeroFactura;
            Concepto = concepto;
            Unidades = unidades;
            ProductoID = productoID;
        }

        public FacturaLineaDTO(string concepto, int unidades)
        {
            Concepto = concepto;
            Unidades = unidades;
        }

        public int NumeroFactura { get; set; }
        public string Concepto { get; set; }
        public int Unidades { get; set; }
        public int ProductoID { get; set; }
        public override string ToString() => "NumFac: " + NumeroFactura + "\tConcepto: " + Concepto + "\tUnidades: " + Unidades + "\tProducto ID: " + ProductoID;
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public static List<FacturaLineaDTO> ObtenerDatos()
        {
            try
            {
                List<FacturaLineaDTO> lista = new List<FacturaLineaDTO>();
                string query = "SELECT LineasFactura.Numero, Factura.Concepto, LineasFactura.Unidades, LineasFactura.Producto_Numero FROM LineasFactura INNER JOIN Factura ON Factura.Numero = LineasFactura.Factura_numero";
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new FacturaLineaDTO(Convert.ToInt32(reader["Numero"]), Convert.ToString(reader["Concepto"]), Convert.ToInt32(reader["Unidades"]), Convert.ToInt32(reader["Producto_Numero"])));
                    }
                }
                return lista;
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
                return null;
            }
        }

        public static List<FacturaLineaDTO> UnidadesTotalesPorFactura()
        {
            string query = "SELECT Factura.Concepto, SUM(LineasFactura.Unidades) FROM Factura INNER JOIN LineasFactura ON LineasFactura.Factura_numero = Factura.Numero GROUP BY Factura.Concepto ORDER BY Factura.Concepto";
            List<FacturaLineaDTO> lista = new List<FacturaLineaDTO>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        lista.Add(new FacturaLineaDTO(reader.GetString(0), reader.GetInt32(1)));
                    }
                    return lista;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
                return null;
            }
        }

        
    }
}
