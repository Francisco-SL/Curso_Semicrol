using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semicrol.Cursos.Servicios;
using Semicrol.Cursos.Dominio;
namespace FormBindingFacaturas
{
    public partial class Form1 : Form
    {
        IServicioFacturacion servicio;
        List<Factura> lista;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            servicio = new ServicioFacturas();
            lista = servicio.ListarFacturas();
            bindingSource1.DataSource = lista;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btnFiltro(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            bindingSource1.Filter = rb.Text + "='" + txtFiltro.Text + "'";
        }

        private void rbSin_CheckedChanged(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            txtFiltro.Text = "";
        }
    }
}
