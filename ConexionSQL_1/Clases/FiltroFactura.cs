using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL_1.Clases;
namespace ConexionSQL_1.Clases
{
    class FiltroFactura
    {
        public int Numero { get; set; }
        public string Concepto { get; set; }

        public static List<FacturaActiveRecord> BuscarTodos(FiltroFactura f)
        {
            string query = "SELECT * FROM Factura";
            List<FacturaActiveRecord> list = new List<FacturaActiveRecord>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(FacturaActiveRecord.CadenaConexion))
                {
                    conexion.Open();
                    if (f.Numero != 0)
                    {
                        query += " WHERE Numero = @prNum";
                    }
                    if (f.Concepto != null)
                    {
                        query += " WHERE Concepto = @prCon";
                    }
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

    }
    
}
