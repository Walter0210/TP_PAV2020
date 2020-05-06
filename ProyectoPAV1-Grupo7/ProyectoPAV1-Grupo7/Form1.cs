using ProyectoPAV1_Grupo7.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario");
                txtBoxUsuario.Focus();
            }
            else if (txtBoxContrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña!");
                txtBoxContrasena.Focus();
            }
            else
            {
                this.Hide();
                frm_Menu menu = new frm_Menu();
                menu.ShowDialog();

            }
        }
    }
}
