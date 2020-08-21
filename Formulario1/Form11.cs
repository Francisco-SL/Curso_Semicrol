using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Form11 : Form
    {
        DataSet miDataSet;

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            miDataSet = new DataSet();
            DataTable tabla = new DataTable("tabla1");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            DataRow fila = tabla.NewRow();
            fila["Nombre"] = "Pedro";
            fila["Apellidos"] = "Alvarez";
            tabla.Rows.Add(fila);
                                 
            DataTable tabla2 = new DataTable("tabla2");
            tabla2.Columns.Add("Numero");
            tabla2.Columns.Add("Concepto");
            DataRow fila2 = tabla2.NewRow();
            fila2["Numero"] = "1";
            fila2["Concepto"] = "Ordenador";
            tabla2.Rows.Add(fila2);
                                                  
            miDataSet.Tables.Add(tabla);
            miDataSet.Tables.Add(tabla2);
            dataGridView1.DataSource = miDataSet;
            dataGridView1.DataMember = "tabla2";
        }
    }
}
