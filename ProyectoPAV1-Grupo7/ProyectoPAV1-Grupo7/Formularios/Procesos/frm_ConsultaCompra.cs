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

namespace ProyectoPAV1_Grupo7.Formularios.Procesos
{
    public partial class frm_ConsultaCompra : Form
    {
        public frm_ConsultaCompra()
        {
            InitializeComponent();
        }


        //Inicio de VENTANA
        private void Frm_ConsultaCompra(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Ticket";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrTicket.DataSource = tabla;

        }

        private void frm_ConsultaCompra_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
