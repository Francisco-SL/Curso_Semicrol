using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaccion
{
    class Program
    {
     
        static void Main(string[] args)
        {
            string query = "INSERT INTO Factura VALUES (3, 'erg')";
            string query2 = "INSERT INTO LineasFactura VALUES (1, 3, 1, 8)";

            SqlTransaction objTrans = null;
            using (SqlConnection objConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\formacion\source\repos\Francisco Sierra Luciarte\Curso_Semicrol\BBDD\BD2\Facturacion_DB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                objConn.Open();
                objTrans = objConn.BeginTransaction();
                SqlCommand objCmd1 = new SqlCommand(query, objConn);
                SqlCommand objCmd2 = new SqlCommand(query2, objConn);
                try
                {
                    objCmd1.ExecuteNonQuery();
                    objCmd2.ExecuteNonQuery(); 

                    objTrans.Commit();
                    Console.WriteLine("HECHO");
                }
                catch (Exception)
                {
                    objTrans.Rollback();
                    Console.WriteLine("ERROR");
                }
                finally
                {
                    objConn.Close();
                }

                Console.ReadLine();
            }
        }

    }
}

