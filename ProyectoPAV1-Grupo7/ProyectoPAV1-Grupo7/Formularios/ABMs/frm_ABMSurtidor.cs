using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios.ABMs
{
    public partial class frm_ABMSurtidor : Form
    {
        public frm_ABMSurtidor()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Surtidor";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            grdSurtidor.DataSource = tabla;

        }
    }
}
