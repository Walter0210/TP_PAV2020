using Microsoft.Reporting.WinForms;
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

namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    public partial class frm_ListadoVentaProductos : Form
    {
        public frm_ListadoVentaProductos()
        {
            InitializeComponent();
        }

        private void frm_ListadoVentaProductos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = ObtenerListadoTickets();

            ReportDataSource ds = new ReportDataSource("DatosTickets", table);

            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("restriccion", "");
            //reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private DataTable ObtenerListadoTickets()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format(@"SELECT        Ticket.numTicket, Ticket.fecha, Estacion.razonSocial, TicketXProducto.precio, TicketXProducto.cantidad, Producto.descripcion, Surtidor.numeroSurtidor, Ticket.cantidad AS CantComb, TipoCombustible.nombre
                            FROM            Producto INNER JOIN
                            TicketXProducto ON Producto.idProducto = TicketXProducto.idProducto CROSS JOIN
                            Ticket INNER JOIN
                            Surtidor ON Ticket.numeroSurtidor = Surtidor.numeroSurtidor AND Ticket.cuit = Surtidor.cuit INNER JOIN
                            Estacion ON Surtidor.cuit = Estacion.CUIT INNER JOIN
                            TipoCombustible ON Surtidor.idTipoCombustible = TipoCombustible.idTipoCombustible");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }
    }
}
