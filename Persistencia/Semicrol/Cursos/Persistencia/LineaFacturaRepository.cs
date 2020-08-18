
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Semicrol.Cursos.Persistencia.Filtros;
using Semicrol.Cursos.Dominio;

namespace Semicrol.Cursos.Persistencia
{
    public class LineaFacturaRepository : ILineasFacturaRepository
    {
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public void Insertar(LineaFactura lf)
        {
            string query = "INSERT INTO LineasFactura VALUES (@prNumero, @prNumFac, (SELECT Numero FROM Producto WHERE Producto.Nombre = @prProdNombre), @prUnidades)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNumero", lf.Numero));
                    comando.Parameters.Add(new SqlParameter("@prUnidades", lf.Unidades));
                    comando.Parameters.Add(new SqlParameter("@prNumFac", lf.Factura.Numero));
                    comando.Parameters.Add(new SqlParameter("@prProdNombre", lf.Producto));
                    comando.ExecuteNonQuery();
                    Console.WriteLine("{0} ingresada en la BBDD", ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR SQL: {0}", e.Message);
            }
        }

        public void Eliminar(LineaFactura f)
        {
            string query = "DELETE LineasFactura WHERE Numero = @prNum";
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

        public void ActualizarUnidadesLinea(LineaFactura f)
        {
            string query = "UPDATE LineasFactura SET Unidades = @prUni WHERE Numero = @prNum";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prUni", f.Unidades));
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

        public List<LineaFactura> BuscarTodos()
        {
            string query = "SELECT LineasFactura.Numero, LineasFactura.Numero, Producto.Nombre, LineasFactura.Unidades FROM LineasFactura INNER JOIN Producto ON Producto.Numero = LineasFactura.Producto_Numero";
            List<LineaFactura> list = new List<LineaFactura>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new LineaFactura(reader.GetInt32(0), reader.GetString(2), reader.GetInt32(3), new Factura(reader.GetInt32(1), reader.GetString(2))));
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
    }
}