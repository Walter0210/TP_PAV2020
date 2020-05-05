using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios
{
    public partial class frm_ABMEstacion : Form
    {
        public frm_ABMEstacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Inicio de VENTANA
        private void frm_ABMEstacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            CargarGrilla();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxCalle.Text = "";
            txtBoxCuit.Text = "";
            txtBoxNumero.Text = "";
            txtBoxRazonSocial.Text = "";
        }

        //FUNCION CARGAR GRILLA

        private void CargarGrilla()
        {

            string sql = "SELECT CUIT , razonSocial FROM Estacion";
            DataTable tabla = consulta(sql);
            dgrEstacion.DataSource = tabla;
        }

    }
}
