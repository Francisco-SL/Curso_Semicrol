using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class Consulta
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;
            SqlDataReader reader = null;
            string query = "SELECT * FROM Factura";
            try
            {
                conexion = new SqlConnection(FacturaActiveRecord.CadenaConexion);
                conexion.Open();
                comando = new SqlCommand(query, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Factura: {0}\t\tConcepto: {1}", reader["Numero"], reader["Concepto"]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
            finally
            {
                reader.Close();
                conexion.Close();
            }
            Console.ReadLine();
        }
    }
}
