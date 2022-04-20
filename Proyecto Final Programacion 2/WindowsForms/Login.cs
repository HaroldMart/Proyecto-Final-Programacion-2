using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Librerias_Clases;
using System.Data.SqlClient;

namespace WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Server = DESKTOP-NI2ORBL; Database = SellPoint; Trusted_Connection = True");

        //Metodo del login del usuario
        public void Loguear(string usuario, string clave)
        {
            try
            {
                Conexion conexion = new Conexion();

                Conexion.GetConnection();

                SqlCommand cmd = new SqlCommand("SELECT UserNameEntidad,PasswordEntidad FROM Entidades WHERE UserNameEntidad=@Usuario AND PasswordEntidad=@clave", cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Global.userName = txtUsuario.Text;
                    this.Hide();
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos.");
                }

            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Loguear(this.txtUsuario.Text, this.txtClave.Text);
        }
    }
}
