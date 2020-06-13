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
            cargarComboResponsable();
            cargarComboSolicitante();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = ObtenerListadoTickets();

            ReportDataSource ds = new ReportDataSource("DatosTickets", table);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", "");
            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private DataTable ObtenerListadoTickets()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                "GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "ORDER BY T.numTicket");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private void cargarComboResponsable()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT  E.nombre + ' ' + E.apellido as 'ApeNom', E.legajo FROM Empleado E";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbResponsable.DataSource = tabla;
            cmbResponsable.DisplayMember = "ApeNom";
            cmbResponsable.ValueMember = "legajo";
            cmbResponsable.SelectedIndex = -1;
        }

        private void cargarComboSolicitante()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            cmbSolicitante.DataSource = tabla;
            cmbSolicitante.DisplayMember = "razonSocial";
            cmbSolicitante.ValueMember = "CUIT";
            cmbSolicitante.SelectedIndex = -1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbSolicitante.SelectedIndex != -1 || cmbResponsable.SelectedIndex != -1)
            {
                int cuitEstacion = int.Parse(cmbSolicitante.SelectedValue.ToString());

                ReportDataSource ds = new ReportDataSource("DatosTickets", BuscarVentasEstacion(cuitEstacion));

                //reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPAV1_Grupo7.Formularios.Reportes.ListadoOrdenesCompra.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", "Filtrando por CUIT = " + cuitEstacion);
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else if (dtpDesde.Value != dtpHasta.Value)
            {
                ReportDataSource ds = new ReportDataSource("DatosTickets", BuscarVentasEntre(dtpDesde.Value, dtpHasta.Value));

                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", "Filtrando por fecha desde: " + dtpDesde.Value.ToString() + " hasta: " + dtpHasta.Value.ToString());
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe seleccionar por lo menos un filtro!");
            }
        }

        private DataTable BuscarVentasEntre(DateTime desde, DateTime hasta)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                " WHERE T.fecha BETWEEN " + "'" + desde.ToString() + "'" + " AND " + "'" + hasta.ToString() + "' " +
                "GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "ORDER BY T.numTicket";

            //string sql = "SELECT * FROM Estacion WHERE CUIT = " + solicitante;
            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private DataTable BuscarVentasEstacion(int cuitEstacion)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                " WHERE E.CUIT = " + cuitEstacion +
                "GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "ORDER BY T.numTicket";

            //string sql = "SELECT * FROM Estacion WHERE CUIT = " + solicitante;
            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }
    }
}
