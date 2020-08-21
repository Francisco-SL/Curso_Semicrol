using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Form16 : Form
    {
        SqlConnection conexion;
        SqlDataAdapter AdaptadorSQL;
        DataSet miDataSet;
        public static string CadenaConexion => ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            try
            {
                miDataSet = new DataSet();
                string query = "SELECT * FROM Factura";
                string queryInsertar = "INSERT INTO Factura VALUES (@prNum, @prCon)";
                string queryActualizar = "UPDATE Factura SET Concepto = @prCon WHERE Numero = @prNum";
                string queryEliminar = "DELETE FROM Factura WHERE Numero = @prNum";
                conexion = new SqlConnection(CadenaConexion);
                conexion.Open();
                SqlCommand comandoSeleccionar = conexion.CreateCommand();
                comandoSeleccionar.CommandText = query;
                comandoSeleccionar.CommandType = CommandType.Text;

                SqlCommand comandoInsertar = conexion.CreateCommand();
                comandoInsertar.CommandType = CommandType.Text;
                comandoInsertar.CommandText = queryInsertar;
                comandoInsertar.Parameters.Add(new SqlParameter("@prNum", SqlDbType.Int, 30, "Numero"));
                comandoInsertar.Parameters.Add(new SqlParameter("@prCon", SqlDbType.NVarChar, 30, "Concepto"));
                comandoInsertar.Parameters["@prNum"].SourceVersion = DataRowVersion.Original;

                SqlCommand comandoActualizar = conexion.CreateCommand();
                comandoActualizar.CommandType = CommandType.Text;
                comandoActualizar.CommandText = queryActualizar;
                comandoActualizar.Parameters.Add(new SqlParameter("@prCon", SqlDbType.NVarChar, 30, "Concepto"));
                comandoActualizar.Parameters.Add(new SqlParameter("@prNum", SqlDbType.Int, 30, "Numero"));
                comandoActualizar.Parameters["@prNum"].SourceVersion = DataRowVersion.Original;

                SqlCommand comandoEliminar = conexion.CreateCommand();
                comandoEliminar.CommandType = CommandType.Text;
                comandoEliminar.CommandText = queryEliminar;
                comandoEliminar.Parameters.Add(new SqlParameter("@prNum", SqlDbType.Int, 30, "Numero"));
                comandoEliminar.Parameters["@prNum"].SourceVersion = DataRowVersion.Original;

                AdaptadorSQL = new SqlDataAdapter();
                AdaptadorSQL.SelectCommand = comandoSeleccionar;
                AdaptadorSQL.InsertCommand = comandoInsertar;
                AdaptadorSQL.UpdateCommand = comandoActualizar;
                AdaptadorSQL.DeleteCommand = comandoEliminar;
                AdaptadorSQL.Fill(miDataSet, "Factura");

                bindingSource1.DataSource = miDataSet.Tables["Factura"];
                dataGridView1.DataSource = bindingSource1;

                txtNumero.DataBindings.Add("Text", bindingSource1, "Numero");
                txtConcepto.DataBindings.Add("Text", bindingSource1, "Concepto");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR SQL");
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                AdaptadorSQL.Update(miDataSet, "Factura");
                MessageBox.Show("BD Actualizada");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR SQL");
            }
        }

        private void Form16_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            bindingSource1.Sort = "Concepto";
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            txtPosicion.Text = bindingSource1.Position.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Concepto='" + txtFiltro.Text + "'";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            txtFiltro.Text = "";
        }
    }
}
