using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConexionSQL_1.Clases
{
    class FacturaActiveRecord
    {
        // se encarga de seleccionar e insertar datos en la DB
        public FacturaActiveRecord(int numero, string concepto)
        {
            Numero = numero;
            Concepto = concepto;
        }

        public FacturaActiveRecord(int numero)
        {
            Numero = numero;
        }

        public int Numero { get; set; }
        public string Concepto { get; set; }
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        public override string ToString() => "Factura: " + Concepto + " (" + Numero + ")";
        public static List<FacturaActiveRecord> BuscarTodos()
        {
            string query = "SELECT * FROM Factura";
            List<FacturaActiveRecord> list = new List<FacturaActiveRecord>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
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
            string query = "INSERT INTO Factura VALUES (@prNum, @prCon)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", Numero));
                    comando.Parameters.Add(new SqlParameter("@prCon", Concepto));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} ingresada en la BBDD", ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public void Eliminar()
        {
            string query = "DELETE Factura WHERE Factura.Numero = @prNum AND Factura.Concepto = @prCon";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", Numero));
                    comando.Parameters.Add(new SqlParameter("@prCon", Concepto));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} eliminado en la BBDD", ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public static FacturaActiveRecord Buscar(int num)
        {
            string query = "SELECT * FROM Factura WHERE Factura.Numero = @prNum";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", num));
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        return new FacturaActiveRecord(Convert.ToInt32(reader["Numero"]), Convert.ToString(reader["Concepto"]));
                    }
                    else
                    {
                        Console.WriteLine("No encuentra nada");
                        return null;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
                return null;
            }
        }

        public void Actualizar(string NuevoConcepto)
        {
            string query = "UPDATE Factura SET Concepto = @prConcep WHERE Factura.Numero = @prNum";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prConcep", NuevoConcepto));
                    comando.Parameters.Add(new SqlParameter("@prNum", Numero));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Factura Actualizada");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public static List<FacturaActiveRecord> BuscarConcepto(string Conc)
        {
            string query = "SELECT * FROM Factura WHERE Factura.Concepto = @prCon";

            List<FacturaActiveRecord> list = new List<FacturaActiveRecord>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prCon", Conc));
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

    }

}
