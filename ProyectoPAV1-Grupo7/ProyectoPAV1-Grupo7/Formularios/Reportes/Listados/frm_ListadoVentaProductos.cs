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
            this.rv_ListadoVentas.RefreshReport();
            cargarComboSolicitante();
            txtWhere.Text = string.Empty;
        }

        private void rv_ListadoGeneral_Load(object sender, EventArgs e)
        {
            ReportDataSource ds = new ReportDataSource("DatosTickets", ObtenerListado());

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_ListadoVentas.LocalReport.SetParameters(parametros);

            rv_ListadoVentas.LocalReport.DataSources.Clear();
            rv_ListadoVentas.LocalReport.DataSources.Add(ds);
            rv_ListadoVentas.LocalReport.Refresh();
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

        private void cargarComboSolicitante()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            cmbSolicitante1.DataSource = tabla;
            cmbSolicitante1.DisplayMember = "razonSocial";
            cmbSolicitante1.ValueMember = "CUIT";
            cmbSolicitante1.SelectedIndex = -1;

            //lo mismos datos para el combo en la otra pestaña
            cmbEstacion2.DataSource = tabla;
            cmbEstacion2.DisplayMember = "razonSocial";
            cmbEstacion2.ValueMember = "CUIT";
            cmbEstacion2.SelectedIndex = -1;
            
        }

        private void btnFiltrar1_Click(object sender, EventArgs e)
        {
                ArmarStringFiltros(cmbSolicitante1, dtpDesde1, dtpHasta1);
                ReportDataSource ds = new ReportDataSource("DatosTickets", BuscarVentasEstacion());

                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", stringRestriccion);
                rv_ListadoVentas.LocalReport.SetParameters(parametros);

                rv_ListadoVentas.LocalReport.DataSources.Clear();
                rv_ListadoVentas.LocalReport.DataSources.Add(ds);
                rv_ListadoVentas.RefreshReport();
        }

        private void ArmarStringFiltros(ComboBox estacion, DateTimePicker desde, DateTimePicker hasta)
        {
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;

            string format = "yyyy-MM-dd HH:mm:ss";
            string shortFormat = "dd-MM-yyyy";

            if (estacion.SelectedIndex != -1)
            {
                if (stringRestriccion == string.Empty)
                {
                    txtWhere.Text = " WHERE E.CUIT = " + estacion.SelectedValue;
                    stringRestriccion = "Listado limitado a: Estacion: " + estacion.Text;
                }
                else
                {
                    //txtWhere.Text += " AND E.CUIT = " + cmbSolicitante1.SelectedValue;
                    //stringRestriccion += " | Estacion : " + cmbSolicitante1.Text;
                }
            }
            if (eligioFechaDesde || eligioFechaHasta)
            {
                if (txtWhere.Text == string.Empty)
                {
                    txtWhere.Text = " WHERE T.fecha BETWEEN " + "'" + desde.Value.ToString(format) + "'" + " AND " + "'" + hasta.Value.ToString(format) + "'";
                    stringRestriccion = "Listado limitado a las Fechas: " + "'" + desde.Value.ToString(shortFormat) + "'" + " Y " + "'" + hasta.Value.ToString(shortFormat) + "'";
                }
                else
                {
                    txtWhere.Text += " AND T.fecha BETWEEN " + "'" + desde.Value.ToString(format) + "'" + " AND " + "'" + hasta.Value.ToString(format) + "'";
                    stringRestriccion += " | Fecha: " + "'" + desde.Value.ToString(shortFormat) + "'" + " Y " + "'" + hasta.Value.ToString(shortFormat) + "'";
                }
            }
        }

        private DataTable BuscarVentasEstacion()
        {
            ConexionBD conexion = new ConexionBD();
           
            string sql = "SELECT T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion, COUNT(TP.numeroTicket) AS 'CantDetalles' " +
                " FROM Ticket T JOIN Estacion E on T.cuit = E.CUIT JOIN UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida LEFT JOIN TicketXProducto TP on T.numTicket = TP.numeroTicket " +
                txtWhere.Text +
                " GROUP BY T.numTicket, T.fecha, E.razonSocial, T.numeroSurtidor, T.cantidad, UM.nombre, T.observacion" +
                " ORDER BY T.numTicket";

            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private void btnLimpiarFiltrosListado1_Click(object sender, EventArgs e)
        {
            cmbSolicitante1.SelectedIndex = -1;
            dtpDesde1.Value = DateTime.Now;
            dtpHasta1.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            stringRestriccion = string.Empty;
            txtWhere.Text = string.Empty;

            DataTable table = new DataTable();
            table = ObtenerListado();

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_ListadoVentas.LocalReport.SetParameters(parametros);

            ReportDataSource ds = new ReportDataSource("DatosTickets", table);
            rv_ListadoVentas.LocalReport.DataSources.Clear();
            rv_ListadoVentas.LocalReport.DataSources.Add(ds);
            rv_ListadoVentas.RefreshReport();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaDesde = true;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaHasta = true;
        }

        private void rv_CantidadVendidaProductos_Load(object sender, EventArgs e)
        {
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;

            ReportDataSource ds = new ReportDataSource("DatosCantProdVendida", ObtenerListadoCantidadVendida());

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_CantidadVendidaProductos.LocalReport.SetParameters(parametros);

            rv_CantidadVendidaProductos.LocalReport.DataSources.Clear();
            rv_CantidadVendidaProductos.LocalReport.DataSources.Add(ds);
            rv_CantidadVendidaProductos.RefreshReport();
        }

        private DataTable ObtenerListadoCantidadVendida()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = "SELECT p.descripcion, SUM(tp.cantidad) AS cantVendida " +
                "FROM Ticket T left join TicketXProducto TP on TP.numeroTicket = T.numTicket JOIN Producto P on TP.idProducto = P.idProducto JOIN Estacion E on T.cuit = E.CUIT " +
                txtWhere.Text + 
                " GROUP BY p.descripcion " + 
                "ORDER BY cantVendida desc";

            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;
        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            ArmarStringFiltros(cmbEstacion2, dtp_fechaDesde2, dtp_fechaHasta2);
            ReportDataSource ds = new ReportDataSource("DatosCantProdVendida", ObtenerListadoCantidadVendida()); 

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_CantidadVendidaProductos.LocalReport.SetParameters(parametros);

            rv_CantidadVendidaProductos.LocalReport.DataSources.Clear();
            rv_CantidadVendidaProductos.LocalReport.DataSources.Add(ds);
            rv_CantidadVendidaProductos.RefreshReport();
        }

        private void btnLimpiarFiltros2_Click(object sender, EventArgs e)
        {
            cmbEstacion2.SelectedIndex = -1;
            dtp_fechaDesde2.Value = DateTime.Now;
            dtp_fechaHasta2.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            stringRestriccion = string.Empty;
            txtWhere.Text = string.Empty;
            
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_CantidadVendidaProductos.LocalReport.SetParameters(parametros);

            ReportDataSource ds = new ReportDataSource("DatosCantProdVendida", ObtenerListadoCantidadVendida());
            rv_CantidadVendidaProductos.LocalReport.DataSources.Clear();
            rv_CantidadVendidaProductos.LocalReport.DataSources.Add(ds);
            rv_CantidadVendidaProductos.RefreshReport();
        }
    }
}
