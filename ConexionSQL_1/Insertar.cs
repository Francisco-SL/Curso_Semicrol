using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class Insertar
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;
            SqlDataReader reader = null;
            string query = "INSERT INTO Factura VALUES (3, 'Otra')";
            try
            {
                conexion = new SqlConnection(FacturaActiveRecord.CadenaConexion);
                conexion.Open();
                comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("Valor ingresado en la BBDD");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
            finally
            {
                Console.ReadLine();
                reader.Close();
                conexion.Close();
            }
        }
    }
}
