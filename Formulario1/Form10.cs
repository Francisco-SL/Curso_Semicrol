using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        private void Form10_Load(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Factura VALUES (@prNum, @prConcep)";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add(new SqlParameter("@prNum", txtNumero.Text));
                    comando.Parameters.Add(new SqlParameter("@prConcep", txtConcepto.Text));
                    comando.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CargarFacturas();
            }
        }

        private void CargarFacturas()
        {
            string query = "SELECT * FROM Factura";
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    DataTable table = new DataTable();
                    SqlDataReader reader = comando.ExecuteReader();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
