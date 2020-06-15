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
        //private string stringWhere;
        private bool eligioFechaDesde = false;
        private bool eligioFechaHasta = false;
        string stringRestriccion = string.Empty;

        public frm_ListadoVentaProductos()
        {
            InitializeComponent();
        }

        private void frm_ListadoVentaProductos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            cargarComboSolicitante();
            txtWhere.Text = string.Empty;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = ObtenerListado();

            ReportDataSource ds = new ReportDataSource("DatosTickets", table);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private DataTable ObtenerListado()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                "GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "ORDER BY T.numTicket");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
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
                ArmarStringFiltros();
                ReportDataSource ds = new ReportDataSource("DatosTickets", BuscarVentasEstacion());
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", stringRestriccion);
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
        }

        private void ArmarStringFiltros()
        {
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;

            string format = "yyyy-MM-dd HH:mm:ss";
            string shortFormat = "dd-MM-yyyy";

            if (cmbSolicitante.SelectedIndex != -1)
            {
                if (stringRestriccion == string.Empty)
                {
                    txtWhere.Text = "WHERE E.CUIT = " + cmbSolicitante.SelectedValue;
                    stringRestriccion = "Listado limitado a: Estacion: " + cmbSolicitante.Text;
                }
                else
                {
                    txtWhere.Text += " AND E.CUIT = " + cmbSolicitante.SelectedValue;
                    stringRestriccion += " | Estacion : " + cmbSolicitante.Text;
                }
            }
            if (eligioFechaDesde || eligioFechaHasta)
            {
                if (txtWhere.Text == string.Empty)
                {
                    txtWhere.Text = "WHERE T.fecha BETWEEN " + "'" + dtpDesde.Value.ToString(format) + "'" + " AND " + "'" + dtpHasta.Value.ToString(format) + "'";
                    stringRestriccion = "Listado limitado a las Fechas: " + "'" + dtpDesde.Value.ToString(shortFormat) + "'" + " AND " + "'" + dtpHasta.Value.ToString(shortFormat) + "'";
                }
                else
                {
                    txtWhere.Text += " AND T.fecha BETWEEN " + "'" + dtpDesde.Value.ToString(format) + "'" + " AND " + "'" + dtpHasta.Value.ToString(format) + "'";
                    stringRestriccion += " | Fecha: " + "'" + dtpDesde.Value.ToString(shortFormat) + "'" + " AND " + "'" + dtpHasta.Value.ToString(shortFormat) + "'";
                }
            }
        }

        private DataTable BuscarVentasEstacion()
        {
            ConexionBD conexion = new ConexionBD();
           
            string sql = "SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                txtWhere.Text +
                "GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "ORDER BY T.numTicket";

            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbSolicitante.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            stringRestriccion = string.Empty;
            txtWhere.Text = string.Empty;

            DataTable table = new DataTable();
            table = ObtenerListado();

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);

            ReportDataSource ds = new ReportDataSource("DatosTickets", table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaDesde = true;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaHasta = true;
        }
         
    }
}
