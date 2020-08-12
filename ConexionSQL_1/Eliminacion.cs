using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class Eliminacion
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;
            SqlDataReader reader = null;
            string query = "DELETE Factura WHERE Factura.Numero = @prNum AND Factura.Concepto = @prConcepto";
            try
            {
                conexion = new SqlConnection(FacturaActiveRecord.CadenaConexion);
                conexion.Open();
                comando = new SqlCommand(query, conexion);
                comando.Parameters.Add(new SqlParameter("@prNum", 3)); // comando.Parameters.AddWithValue("@prNum",3);
                comando.Parameters.Add(new SqlParameter("@prConcepto", "Otra"));
                comando.ExecuteNonQuery();
                Console.WriteLine("Valor eliminado en la BD");
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
