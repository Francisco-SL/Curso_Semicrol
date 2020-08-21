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
    public partial class Form12 : Form
    {
        DataSet miDataSet;
        string TablaFactura = "Factura";
        string TablaLineasFactura = "LineasFactura";
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            miDataSet = new DataSet();
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                SqlDataAdapter adapFact = new SqlDataAdapter("SELECT * FROM Factura", conexion);
                SqlDataAdapter adapLiFa = new SqlDataAdapter("SELECT LineasFactura.Numero, Factura.Concepto, Producto.Nombre, LineasFactura.Unidades FROM LineasFactura INNER JOIN Producto ON Producto.Numero = LineasFactura.Producto_Numero INNER JOIN Factura ON Factura.Numero = LineasFactura.Factura_numero", conexion);
                adapFact.Fill(miDataSet, TablaFactura);
                adapLiFa.Fill(miDataSet, TablaLineasFactura);
                dataGridView1.DataSource = miDataSet;
                dataGridView1.DataMember = TablaLineasFactura;

            }

        }
    }
}
