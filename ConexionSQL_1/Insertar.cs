﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\formacion\source\repos\Francisco Sierra Luciarte\Curso_Semicrol\BBDD\BD2\Facturacion_DB.mdf;Integrated Security=True;Connect Timeout=30";
            try
            {
                conexion = new SqlConnection(cadenaConexion);
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
