using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConexionSQL_1.Clases;

namespace ConexionSQL_1
{
    class Actualizar
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;
            SqlDataReader reader = null;
            string query = "UPDATE Producto SET Producto.Importe = @prPrecio WHERE Producto.Nombre = @prNombre";
            try
            {
                conexion = new SqlConnection(FacturaActiveRecord.CadenaConexion);
                conexion.Open();
                comando = new SqlCommand(query, conexion);
                comando.Parameters.Add(new SqlParameter("@prPrecio", 18));
                comando.Parameters.Add(new SqlParameter("@prNombre", "Galletas"));
                comando.ExecuteNonQuery();
                Console.WriteLine("Producto actualizado en la BBDD");
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
