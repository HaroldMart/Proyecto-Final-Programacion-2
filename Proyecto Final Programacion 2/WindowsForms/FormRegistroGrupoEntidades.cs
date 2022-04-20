using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using Librerias_Clases;
namespace WindowsForms
{
    public partial class FormRegistroGrupoEntidades : Form
    {
        public FormRegistroGrupoEntidades()
        {
            InitializeComponent();
        }

        private void FormRegistroGrupoEntidades_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.GetConnection();
            DataTable dt = new DataTable();
            String consulta = "Select * From GruposEntidades";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.GetConnection());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGE.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtComentario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxStatus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbxNoEliminable.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFechaRegistro.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos dato = new Datos();
            dato.InsertarDatosGE(txtDescripcion.Text,txtComentario.Text, cbxStatus.Text, cbxNoEliminable.Text);

            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos dato = new Datos();
            dato.actualizarDatosGE(Int32.Parse(txtIdGE.Text), txtDescripcion.Text,txtComentario.Text, cbxStatus.Text, cbxNoEliminable.Text);

            MessageBox.Show("Los datos fueron Actualizados Correctamente.");
            dataGridView1.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Datos dato = new Datos();
            dato.eliminarDatosGE(Int32.Parse(txtIdGE.Text));

            MessageBox.Show("Los datos fueron Eliminados Correctamente.");
            dataGridView1.DataSource = llenar_grid();
            Limpiar();
        }

        public void Limpiar()
        {
            txtIdGE.Clear();
            cbxStatus.ResetText();
            txtDescripcion.Clear();
            txtComentario.Clear();
            cbxNoEliminable.ResetText();
            txtFechaRegistro.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal menuPrincipal = new MenuPrincipal();

            menuPrincipal.Show();
        }
    }
}
