using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Semicrol.Cursos.PersistenciaADO
{
    public class FacturaRepository : IFacturaRepositorio
    {

        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public void Insertar(Factura f)
        {
            string query = "INSERT INTO Factura VALUES (@prNum, @prCon)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", f.Numero));
                    comando.Parameters.Add(new SqlParameter("@prCon", f.Concepto));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} ingresada en la BBDD", f.ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public void Borrar(Factura f)
        {
            string query = "DELETE Factura WHERE Numero = @prNum";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", f.Numero));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} eliminada de la BBDD", f.ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public void Actualizar(Factura f)
        {
            string query = "UPDATE Factura SET Concepto = @prCon WHERE Numero = @prNum";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prCon", f.Concepto));
                    comando.Parameters.Add(new SqlParameter("@prNum", f.Numero));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} actualizada en la BD", f.ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public List<Factura> BuscarTodos()
        {
            string query = "SELECT * FROM Factura";
            List<Factura> list = new List<Factura>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Factura(Convert.ToInt32(reader["Numero"]), Convert.ToString(reader["Concepto"])));
                    }
                }
                return list;
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
                return null;
            }
        }

        public List<Factura> BuscarTodos(FiltroFacturaNuevo f)
        {
            string query = "SELECT * FROM Factura";
            List<Factura> list = new List<Factura>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
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
                        list.Add(new Factura(Convert.ToInt32(reader["Numero"]), Convert.ToString(reader["Concepto"])));
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

        public Factura BuscarUno(int f)
        {
            string query = "SELECT * FROM Factura WHERE Numero = @prNum";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", f));
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                        return new Factura(f, Convert.ToString(reader["Concepto"]));
                    else
                        return null;
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
