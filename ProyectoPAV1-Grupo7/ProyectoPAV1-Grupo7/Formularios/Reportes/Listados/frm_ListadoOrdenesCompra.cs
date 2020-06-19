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
            cargarComboSolicitante();
            cargarComboResponsable();
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

        private void frm_ListadoOrdenesCompra_Load(object sender, EventArgs e)
        {
            this.rv_ListadoGeneral.RefreshReport();
            txtWhere.Text = string.Empty;
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
    }
}
