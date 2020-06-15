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
            this.reportViewer1.RefreshReport();
            txtWhere.Text = string.Empty;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = frm_ConsultaOrdenCompra.ObtenerListadoOrdenesCompra();

            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", table);

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", "");
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtWhere.Text = string.Empty;
            stringRestriccion = string.Empty;
            ArmarStringFiltros();
            //int solicitante = int.Parse(cmbSolicitante.SelectedValue.ToString());

            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", ObtenerListado());

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
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

        private DataTable ObtenerListado()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT " +
                txtWhere.Text;

            DataTable tabla = conexion.ejecutar_consulta(sql);
            return tabla;
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
            table = ObtenerListado();

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("restriccion", stringRestriccion);
            reportViewer1.LocalReport.SetParameters(parametros);

            ReportDataSource ds = new ReportDataSource("DatosOrdenesCompra", table);
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
