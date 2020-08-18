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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Insuficiente");
            comboBox1.Items.Add("Suficiente");
            comboBox1.Items.Add("Bien");
            comboBox1.Items.Add("Notable");
            comboBox1.Items.Add("Sobresaliente");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("4");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            MessageBox.Show(combo.SelectedItem.ToString());
        }
    }
}