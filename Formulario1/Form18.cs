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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            List<string> textos = new List<string>();
            textos.Add("Hola");
            textos.Add("Que tal");
            bindingSource1.DataSource = textos;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
