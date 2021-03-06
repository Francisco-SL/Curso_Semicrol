﻿using System;
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
            IPersonasRepository repo = new PersonaRepositoryMemoria();
            IList<Persona> listaPersonas= repo.BuscarTodos();
            comboBox1.DataSource = listaPersonas;
            comboBox1.ValueMember = "Edad";
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
