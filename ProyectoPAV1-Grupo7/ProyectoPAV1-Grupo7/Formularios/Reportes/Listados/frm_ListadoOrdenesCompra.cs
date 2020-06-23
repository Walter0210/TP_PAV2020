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
    public partial class frm_ListadoOrdenesCompra : Form
    {
        private bool eligioFechaDesde = false;
        private bool eligioFechaHasta = false;
        private string stringRestriccion = string.Empty;
        public frm_ListadoOrdenesCompra()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void cargarCombos()
        {
            // RESPONSABLE
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT  E.nombre + ' ' + E.apellido as 'ApeNom', E.legajo FROM Empleado E";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            cmbResponsable.DataSource = tabla;
            cmbResponsable.DisplayMember = "ApeNom";
            cmbResponsable.ValueMember = "legajo";
            cmbResponsable.SelectedIndex = -1;

            //  ESTACION
            ConexionBD conexion1 = new ConexionBD();
            string sql1 = "SELECT * FROM Estacion";
            DataTable tabla1 = conexion1.ejecutar_consulta(sql1);
            cmbSolicitante.DataSource = tabla1;
            cmbSolicitante.DisplayMember = "razonSocial";
            cmbSolicitante.ValueMember = "CUIT";
            cmbSolicitante.SelectedIndex = -1;

            //  NRO ORDEN COMPRA
            ConexionBD conexion2 = new ConexionBD();
            string sql2 = "SELECT * FROM OrdenCompra";
            DataTable tabla2 = conexion2.ejecutar_consulta(sql2);
            cmb_nroOrden.DataSource = tabla2;
            cmb_nroOrden.DisplayMember = "numeroOrdenCompra";
            cmb_nroOrden.ValueMember = "numeroOrdenCompra";
            cmb_nroOrden.SelectedIndex = -1;
        }

        private void frm_ListadoOrdenesCompra_Load(object sender, EventArgs e)
        {
            this.rv_ListadoGeneral.RefreshReport();
            txtWhere.Text = string.Empty;
            this.rv_productosPorOC.RefreshReport();
            this.rv_productosPorOC.RefreshReport();

            txt_Estacion.ReadOnly = true;
            txt_Responsable.ReadOnly = true;
        }

        private void rv_ListadiGeneral_Load(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();
            ObtenerListado();

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", "");
            rv_ListadoGeneral.LocalReport.SetParameters(parametros);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;
            ArmarStringFiltros();
            ObtenerListado();

            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            //rv_ListadoGeneral.LocalReport.SetParameters(parametros);
        }


        private void ObtenerListado()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = "SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT " + txtWhere.Text;

            DataTable table = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", table);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_ListadoGeneral.LocalReport.SetParameters(parametros);
            rv_ListadoGeneral.LocalReport.DataSources.Clear();
            rv_ListadoGeneral.LocalReport.DataSources.Add(ds);
            rv_ListadoGeneral.RefreshReport();
        }
        private void ArmarStringFiltros()
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            string shortFormat = "dd-MM-yyyy";

            if (cmbSolicitante.SelectedIndex != -1)
            {
                if (txtWhere.Text == string.Empty)
                {
                    txtWhere.Text = "WHERE OC.cuitSolicitante = " + cmbSolicitante.SelectedValue;
                    stringRestriccion = "Estación: " + cmbSolicitante.Text;
                }
                else
                {
                    txtWhere.Text += " AND OC.cuitSolicitante = " + cmbSolicitante.SelectedValue;
                    stringRestriccion += " | Estación: " + cmbSolicitante.Text;
                }
            }
            if (cmbResponsable.SelectedIndex != -1)
            {
                if (txtWhere.Text == string.Empty)
                {
                    txtWhere.Text = "WHERE OC.legajo = " + cmbResponsable.SelectedValue;
                    stringRestriccion = "Responsable: " + cmbResponsable.Text;
                }
                else
                {
                    txtWhere.Text += " AND OC.legajo = " + cmbResponsable.SelectedValue;
                    stringRestriccion += " | Responsable: " + cmbResponsable.Text;
                }
            }
            
            if (eligioFechaDesde || eligioFechaHasta)
            {
                if (txtWhere.Text == string.Empty)
                {
                    txtWhere.Text = "WHERE OC.fecha BETWEEN " + "'" + dtpDesde.Value.ToString(format) + "'" + " AND " + "'" + dtpHasta.Value.ToString(format) + "'";
                    stringRestriccion = "Entre: " + "'" + dtpDesde.Value.ToString(shortFormat) + "'" + " Y " + "'" + dtpHasta.Value.ToString(shortFormat) + "'";
                }
                else
                {
                    txtWhere.Text += " AND OC.fecha BETWEEN " + "'" + dtpDesde.Value.ToString(format) + "'" + " AND " + "'" + dtpHasta.Value.ToString(format) + "'";
                    stringRestriccion += " | Entre: " + "'" + dtpDesde.Value.ToString(shortFormat) + "'" + " Y " + "'" + dtpHasta.Value.ToString(shortFormat) + "'";
                }
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbSolicitante.SelectedIndex = -1;
            cmbResponsable.SelectedIndex = -1;
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;

            DataTable table = new DataTable();
            ObtenerListado();

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_ListadoGeneral.LocalReport.SetParameters(parametros);

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaDesde = true;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaHasta = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //missclick
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;

            ArmarStringFiltros();
            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", ObtenerListadoPromedios());

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            rv_ListadoGeneral.LocalReport.SetParameters(parametros);

            rv_ListadoGeneral.LocalReport.DataSources.Clear();
            rv_ListadoGeneral.LocalReport.DataSources.Add(ds);
            rv_ListadoGeneral.RefreshReport();
        }

        private object ObtenerListadoPromedios()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT " +
                txtWhere.Text;

            DataTable tabla = conexion.ejecutar_consulta(sql);
            return tabla;
        }

        private void rv_productosPorOC_Load(object sender, EventArgs e)
        {
            ObtenerListadoProductosOC();
        }

        private void ObtenerListadoProductosOC()
        {
            object numOrden = cmb_nroOrden.SelectedValue;

            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT DC.numOrdenCompra, P.descripcion as 'idProducto', DC.cantidad, UM.nombre as 'idUnidadMedida', P.precioCompra * DC.cantidad as 'precio', UR.nombre as 'idUrgencia'"
                + " FROM DetalleOrdenCompra DC "
                + "JOIN Producto P ON DC.idProducto = P.idProducto "
                + "JOIN UnidadMedida UM ON DC.idUnidadMedida = UM.idUnidadMedida "
                + "JOIN Urgencia UR ON DC.idUrgencia = UR.idUrgencia " +
                "WHERE DC.numOrdenCompra = '" + numOrden + "'";

            DataTable tabla = conexion.ejecutar_consulta(sql);
            ReportDataSource ds = new ReportDataSource("productosXoc", tabla);

            rv_productosPorOC.LocalReport.DataSources.Clear();
            rv_productosPorOC.LocalReport.DataSources.Add(ds);
            rv_productosPorOC.LocalReport.Refresh();
            rv_productosPorOC.RefreshReport();
        }

        private void btn_filtrarTab3_Click(object sender, EventArgs e)
        {
            ObtenerListadoProductosOC();
            obtenerResponsable();
            obtenerEstacion();
        }

        private void obtenerResponsable()
        {
            if (cmb_nroOrden.SelectedIndex != -1)
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT E.nombre+ ' ' + E.apellido AS apenom FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo WHERE OC.numeroOrdenCompra = " + cmb_nroOrden.SelectedValue;
                DataTable tabla = conexion.ejecutar_consulta(sql);
                txt_Responsable.Text = tabla.Rows[0]["apenom"].ToString();
            }

        }

        private void obtenerEstacion()
        {
            if (cmb_nroOrden.SelectedIndex != -1)
            {

                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT S.razonSocial" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT WHERE OC.numeroOrdenCompra = " + cmb_nroOrden.SelectedValue;
                DataTable tabla = conexion.ejecutar_consulta(sql);
                txt_Estacion.Text = tabla.Rows[0]["razonSocial"].ToString();
            }

        }

        private void btn_limpiarTab3_Click(object sender, EventArgs e)
        {
            txt_Estacion.Clear();
            txt_Responsable.Clear();
            rv_productosPorOC.Clear();
            cmb_nroOrden.SelectedIndex = -1;
        }
    }
}
