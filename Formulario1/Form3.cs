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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Text.Equals("Basico"))
            {
                PanelEdad.Visible = false;
                PanleTelefono.Visible = false;
            }
            else
            {
                PanelEdad.Visible = true;
                PanleTelefono.Visible = true;
            }
        }
    }
}
