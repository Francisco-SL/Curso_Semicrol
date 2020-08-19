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
    public partial class Form7 : Form
    {
        List<Persona> listaPersonas = new List<Persona>();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listaPersonas.Add(new Persona("Pedro", 20));
            listaPersonas.Add(new Persona("Juan", 30));
            comboBox1.DataSource = listaPersonas;
            comboBox1.ValueMember = "Edad";
            comboBox1.DisplayMember = "Nombre";
        }//5
    }
}
