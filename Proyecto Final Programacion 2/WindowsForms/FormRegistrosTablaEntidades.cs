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
    public partial class FormRegistrosTablaEntidades : Form
    {
        public FormRegistrosTablaEntidades()
        {
            InitializeComponent();
        }

        private void FormRegistrosTablaEntidades_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            Conexion.GetConnection();
            DataTable dt = new DataTable();
            String consulta = "Select * From Entidades";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.GetConnection());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
      
            da.Fill(dt); 
            return dt;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos dato = new Datos();
            dato.InsertarDatos(txtUsuario.Text, txtClave.Text, txtDireccion.Text, txtDescripcion.Text,txtLocalidad.Text, cbxTipoEntidad.Text, cbxTipoDocumento.Text, Int32.Parse(txtNumDocumento.Text), txtTelefono.Text, txtURLPaginaWeb.Text, txtURLFacebook.Text, txtURLInstagram.Text, txtURLTwitter.Text, txtURLTiktok.Text, Int32.Parse(txtIdGrupoEntidad.Text), Int32.Parse(txtIdTipoEntidad.Text), Int32.Parse(txtLimitesCreditos.Text), cbxRolEntidad.Text, txtComentario.Text, cbxStatus.Text, cbxNoEliminable.Text);
            
            MessageBox.Show("Los datos fueron agregados con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtClave.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtLocalidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cbxTipoEntidad.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                cbxTipoDocumento.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtNumDocumento.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtURLPaginaWeb.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtURLFacebook.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtURLInstagram.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                txtURLTwitter.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                txtURLTiktok.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                txtIdGrupoEntidad.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                txtIdTipoEntidad.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                txtLimitesCreditos.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                cbxRolEntidad.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                txtComentario.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                cbxStatus.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                cbxNoEliminable.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();

            }
            catch { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos dato = new Datos();
            dato.actualizarDatos(Int32.Parse(txtId.Text),txtUsuario.Text, txtClave.Text, txtDireccion.Text, txtDescripcion.Text, txtLocalidad.Text, cbxTipoEntidad.Text, cbxTipoDocumento.Text, Int32.Parse(txtNumDocumento.Text), txtTelefono.Text, txtURLPaginaWeb.Text, txtURLFacebook.Text, txtURLInstagram.Text, txtURLTwitter.Text, txtURLTiktok.Text, Int32.Parse(txtIdGrupoEntidad.Text), Int32.Parse(txtIdTipoEntidad.Text), Int32.Parse(txtLimitesCreditos.Text), cbxRolEntidad.Text, txtComentario.Text, cbxStatus.Text, cbxNoEliminable.Text);

            MessageBox.Show("Los datos fueron Actualizados Correctamente.");
            dataGridView1.DataSource = llenar_grid();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Datos dato = new Datos();
            dato.eliminarDatos(Int32.Parse(txtId.Text));

            MessageBox.Show("Los datos fueron Eliminados Correctamente.");
            dataGridView1.DataSource = llenar_grid();
            Limpiar();
        }

        public void Limpiar()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            txtDireccion.Clear();
            txtDescripcion.Clear();
            txtLocalidad.Clear();
            cbxTipoEntidad.ResetText();
            cbxTipoDocumento.ResetText();
            txtNumDocumento.Clear();
            txtTelefono.Clear();
            txtURLPaginaWeb.Clear();
            txtURLFacebook.Clear();
            txtURLInstagram.Clear();
            txtURLTwitter.Clear();
            txtURLTiktok.Clear();
            txtIdGrupoEntidad.Clear();
            txtIdTipoEntidad.Clear();
            txtLimitesCreditos.Clear();
            cbxRolEntidad.ResetText();
            txtComentario.Clear();
            cbxStatus.ResetText();
            cbxNoEliminable.ResetText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();

            MenuPrincipal menuPrincipal = new MenuPrincipal();

            menuPrincipal.Show();

        }
    }
}
