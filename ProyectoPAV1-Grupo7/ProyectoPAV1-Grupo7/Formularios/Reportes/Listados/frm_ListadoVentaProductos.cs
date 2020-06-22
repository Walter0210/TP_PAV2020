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
        private string where = string.Empty;

        public frm_ListadoVentaProductos()
        {
            InitializeComponent();
        }

        private void frm_ListadoVentaProductos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            txtWhere.Text = string.Empty;
            this.rv_prodXventas.RefreshReport();

            cargarCombos();
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
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida LEFT JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                "GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion " +
                "ORDER BY T.numTicket");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private void cargarCombos()
        {
            // SOLICITANTE
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            cmbSolicitante.DataSource = tabla;
            cmbSolicitante.DisplayMember = "razonSocial";
            cmbSolicitante.ValueMember = "CUIT";
            cmbSolicitante.SelectedIndex = -1;

            // NUMERO TICKET
            ConexionBD conexion2 = new ConexionBD();
            string sql2 = "SELECT * FROM Ticket";
            DataTable tabla2 = conexion2.ejecutar_consulta(sql2);
            cmb_nroTicket.DataSource = tabla2;
            cmb_nroTicket.DisplayMember = "numTicket";
            cmb_nroTicket.ValueMember = "numTicket";
            cmb_nroTicket.SelectedIndex = -1;
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
                    stringRestriccion = "Listado limitado a las Fechas: " + "'" + dtpDesde.Value.ToString(shortFormat) + "'" + " Y " + "'" + dtpHasta.Value.ToString(shortFormat) + "'";
                }
                else
                {
                    txtWhere.Text += " AND T.fecha BETWEEN " + "'" + dtpDesde.Value.ToString(format) + "'" + " AND " + "'" + dtpHasta.Value.ToString(format) + "'";
                    stringRestriccion += " | Fecha: " + "'" + dtpDesde.Value.ToString(shortFormat) + "'" + " Y " + "'" + dtpHasta.Value.ToString(shortFormat) + "'";
                }
            }
        }

        private DataTable BuscarVentasEstacion()
        {
            ConexionBD conexion = new ConexionBD();
           
            string sql = "SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                "FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida LEFT JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
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

        private void btnCalcular_Click_1(object sender, EventArgs e)
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

        private void rv_prodXventas_Load(object sender, EventArgs e)
        {
            ObtenerListadoProductos();
        }

        private DataTable ObtenerListadoProductos()
        {
            object numTicket = cmb_nroTicket.SelectedValue;

            ConexionBD conexion = new ConexionBD();

            string sql = "SELECT TP.numeroTicket, P.descripcion, TP.cantidad, TP.precio " +
                "FROM TicketXProducto TP join Producto P on TP.idProducto = P.idProducto " +
                "WHERE numeroTicket = '" + numTicket.ToString() + "'";


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private void btn_filtrarVentas_Click(object sender, EventArgs e)
        {
            buscarProductosPorVenta();
        }

        private void buscarProductosPorVenta()
        {

            object numTicket = cmb_nroTicket.SelectedValue;

            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"SELECT TP.numeroTicket, P.descripcion as 'idProducto', TP.cantidad, TP.precio " +
                "FROM TicketXProducto TP join Producto P on TP.idProducto = P.idProducto " +
                "WHERE numeroTicket = '" + numTicket.ToString() + "'";

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("productosXventa", tablaEmpleados);

                rv_prodXventas.LocalReport.DataSources.Clear();
                rv_prodXventas.LocalReport.DataSources.Add(ds);
                rv_prodXventas.LocalReport.Refresh();
                rv_prodXventas.RefreshReport();
                where = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
            }
        }

        private void btn_limpiarVentas_Click(object sender, EventArgs e)
        {
            rv_prodXventas.Clear();
            cmb_nroTicket.SelectedIndex = -1;
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            reportViewer1.Clear();
            cmbSolicitante.SelectedIndex = -1;
        }
    }
}
