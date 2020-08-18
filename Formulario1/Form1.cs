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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola desde Windows Forms");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + cajaTexto.Text + "\nApellidos: " + cajaTexto2.Text, "Datos de la persona");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show((Convert.ToDouble(cajaNota1.Text) + Convert.ToDouble(cajaNota2.Text) + Convert.ToDouble(cajaNota3.Text)).ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Se inicializa el formulario");
        }
    }
}
