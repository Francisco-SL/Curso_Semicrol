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
    public partial class Form15 : Form
    {

        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                SqlDataAdapter adapFact = new SqlDataAdapter("SELECT * FROM Factura", conexion);
                SqlDataAdapter adapLiFa = new SqlDataAdapter("SELECT * FROM LineasFactura", conexion);
                adapFact.Fill(dataSet11, "Factura");
                adapLiFa.Fill(dataSet11, "LineasFactura");
                dataGridView1.DataSource = dataSet11;
                dataGridView2.DataSource = dataSet11;
                dataGridView1.DataMember = "Factura";
                dataGridView2.DataMember = "LineasFactura";
                //dataSet11.Relations.Add("relacion", dataSet11.Tables["Factura"].Columns["Numero"], dataSet11.Tables["LineasFactura"].Columns["Factura_numero"]);
            }
        }
    }
}
