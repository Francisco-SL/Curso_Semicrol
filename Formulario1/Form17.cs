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
    public partial class Form17 : Form
    {

        SqlConnection conexion;
        SqlDataAdapter AdaptadorSQL;
        DataSet miDataSet;
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["ConexionCine"].ConnectionString;

        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            try
            {
                miDataSet = new DataSet();
                string querySeleccionar = "SELECT * FROM Persona";
                string queryInsertar = "INSERT INTO Persona VALUES (@prDNI, @prNom, @prApe)";
                string queryActualizar = "UPDATE Persona SET Nombre = @prNom, Apellidos = @prApe WHERE DNI = @prDNI";
                string queryEliminar = "DELETE FROM Persona WHERE DNI = @prDNI";
                conexion = new SqlConnection(CadenaConexion);
                conexion.Open();
                SqlCommand comandoSeleccionar = conexion.CreateCommand();
                comandoSeleccionar.CommandText = querySeleccionar;
                comandoSeleccionar.CommandType = CommandType.Text;

                SqlCommand comandoInsertar = conexion.CreateCommand();
                comandoInsertar.CommandType = CommandType.Text;
                comandoInsertar.CommandText = queryInsertar;
                comandoInsertar.Parameters.Add(new SqlParameter("@prDNI", SqlDbType.NVarChar, 25, "DNI"));
                comandoInsertar.Parameters.Add(new SqlParameter("@prNom", SqlDbType.NVarChar, 25, "Nombre"));
                comandoInsertar.Parameters.Add(new SqlParameter("@prApe", SqlDbType.NVarChar, 25, "Apellidos"));
                comandoInsertar.Parameters["@prDNI"].SourceVersion = DataRowVersion.Original;

                SqlCommand comandoActualizar = conexion.CreateCommand();
                comandoActualizar.CommandType = CommandType.Text;
                comandoActualizar.CommandText = queryActualizar;
                comandoActualizar.Parameters.Add(new SqlParameter("@prDNI", SqlDbType.NVarChar, 25, "DNI"));
                comandoActualizar.Parameters.Add(new SqlParameter("@prNom", SqlDbType.NVarChar, 25, "Nombre"));
                comandoActualizar.Parameters.Add(new SqlParameter("@prApe", SqlDbType.NVarChar, 25, "Apellidos"));
                comandoActualizar.Parameters["@prDNI"].SourceVersion = DataRowVersion.Original;

                SqlCommand comandoEliminar = conexion.CreateCommand();
                comandoEliminar.CommandType = CommandType.Text;
                comandoEliminar.CommandText = queryEliminar;
                comandoEliminar.Parameters.Add(new SqlParameter("@prDNI", SqlDbType.VarChar, 25, "DNI"));
                comandoEliminar.Parameters["@prDNI"].SourceVersion = DataRowVersion.Original;

                AdaptadorSQL = new SqlDataAdapter();
                AdaptadorSQL.SelectCommand = comandoSeleccionar;
                AdaptadorSQL.InsertCommand = comandoInsertar;
                AdaptadorSQL.UpdateCommand = comandoActualizar;
                AdaptadorSQL.DeleteCommand = comandoEliminar;
                AdaptadorSQL.Fill(miDataSet, "Persona");

                bindingSource1.DataSource = miDataSet.Tables["Persona"];

                dataGridView1.DataSource = bindingSource1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR SQL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdaptadorSQL.Update(miDataSet, "Persona");
                MessageBox.Show("BD Actualizada");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR SQL");
            }
        }

        private void Form17_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR SQL");
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }
    }
}
