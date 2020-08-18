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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void MostrarColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            EtiquetaColor.Text = rb.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Color seleccionado: " + radioButton1.Text);
            else if (radioButton2.Checked)
                MessageBox.Show("Color seleccionado: " + radioButton2.Text);
            else if (radioButton3.Checked)
                MessageBox.Show("Color seleccionado: " + radioButton3.Text);
        }

        private void AprobadoSuspenso_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            AprobadoSuspenso.Text = rb.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EsInformatico.Checked)            
                MessageBox.Show("La caja esta checkeada");
            else
                MessageBox.Show("La caja no esta checkeada");
        }
    }
}
