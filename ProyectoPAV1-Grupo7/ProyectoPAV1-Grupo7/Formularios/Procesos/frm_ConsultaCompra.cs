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

        private int indiceNroTicket;


        //Inicio de VENTANA
        private void Frm_ConsultaCompra(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "FROM Ticket T join Estacion E on T.cuit = E.CUIT join UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrTicket.DataSource = tabla;
        }

        private void CargarGrillaDetalles(int numTicket)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT TP.numeroTicket, P.descripcion, TP.cantidad, TP.precio " +
                "FROM TicketXProducto TP join Producto P on TP.idProducto = P.idProducto " + 
                "WHERE numeroTicket = '" + numTicket.ToString() + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrTicketProducto.DataSource = tabla;
        }



        private void frm_ConsultaCompra_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgrTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceNroTicket = e.RowIndex;
            if (indiceNroTicket != -1)
            {
                DataGridViewRow fila = dgrTicket.Rows[indiceNroTicket];
                int numTicket = (int)fila.Cells["NumeroTicket"].Value;
                CargarGrillaDetalles(numTicket);
            }
        }
    }
}
