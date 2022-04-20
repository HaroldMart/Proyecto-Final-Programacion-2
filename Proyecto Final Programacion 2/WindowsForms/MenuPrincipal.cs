using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Librerias_Clases;

namespace WindowsForms
{
    public partial class MenuPrincipal : Form
    {
        bool isCollapse;
        public MenuPrincipal()
        {
            InitializeComponent();
            lblUsuario.Text = Global.userName;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel1.Height += 100;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panel1.Height -= 100;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapse = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel2.Height += 100;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                panel2.Height -= 100;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapse = true;
                }
            }
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSistema_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnEntidades_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistrosTablaEntidades registroTablaEntidades = new FormRegistrosTablaEntidades();

            registroTablaEntidades.Show();
        }

        private void btnTPEntidades_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistrosTipoEntidades registroTipoEntidades = new FormRegistrosTipoEntidades();

            registroTipoEntidades.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistroGrupoEntidades registroGrupoEntidades = new FormRegistroGrupoEntidades();

            registroGrupoEntidades.Show();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAcercaDe AcercaDe = new FormAcercaDe();

            AcercaDe.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();

            login.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
