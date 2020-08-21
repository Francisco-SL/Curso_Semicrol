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
    public partial class Form13 : Form
    {
        DataSet miDataSet;
        string TablaFactura = "Factura";
        string TablaLineasFactura = "LineasFactura";
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            miDataSet = new DataSet();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                SqlDataAdapter adapFact = new SqlDataAdapter("SELECT * FROM Factura", conexion);
                SqlDataAdapter adapLiFa = new SqlDataAdapter("SELECT * FROM LineasFactura", conexion);
                adapFact.Fill(miDataSet, TablaFactura);
                adapLiFa.Fill(miDataSet, TablaLineasFactura);
                dataGridView1.DataSource = miDataSet;
                dataGridView2.DataSource = miDataSet;
                dataGridView1.DataMember = TablaFactura;
                dataGridView2.DataMember = TablaLineasFactura;
                miDataSet.Relations.Add("relacion", miDataSet.Tables[TablaFactura].Columns["Numero"], miDataSet.Tables[TablaLineasFactura].Columns["Factura_numero"]);
            }
        }
    }
}
