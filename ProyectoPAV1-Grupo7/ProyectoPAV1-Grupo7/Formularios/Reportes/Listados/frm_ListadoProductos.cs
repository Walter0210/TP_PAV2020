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

namespace ProyectoPAV1_Grupo7.Formularios.Reportes.Listados
{
    public partial class frm_ListadoProductos : Form
    {
        private string stringRestriccion = string.Empty;

        public frm_ListadoProductos()
        {
            InitializeComponent();
        }

        private void frm_ListadoProductos_Load(object sender, EventArgs e)
        {
            this.rv_stockProductos.RefreshReport();
            cmb_comparacion.Items.Add(">");
            cmb_comparacion.Items.Add("<");
            cmb_comparacion.Items.Add("=");

        }

        private void rv_stockProductos_Load(object sender, EventArgs e)
        {
            ObtenerListadoProductos();
        }

        private void ObtenerListadoProductos()
        {
            try
            { 
                ConexionBD conexion = new ConexionBD();

                string sql = "SELECT * FROM Producto";

                DataTable table = conexion.ejecutar_consulta(sql);
                ReportDataSource ds = new ReportDataSource("stockProductos", table);
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("restriccion", "");
                rv_stockProductos.LocalReport.SetParameters(parametros);
                rv_stockProductos.LocalReport.DataSources.Clear();
                rv_stockProductos.LocalReport.DataSources.Add(ds);
                rv_stockProductos.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
            }
        }

        private void btn_filtrarTab3_Click(object sender, EventArgs e)
        {
            stringRestriccion = string.Empty;
            ObtenerStockProductos();
        }

        private void ObtenerStockProductos()
        {
            try
            {
                string stock = txt_stock.Text.Trim();

                ConexionBD conexion = new ConexionBD();

                string sql = "SELECT idProducto, descripcion, stockActual, precioCompra, precioVenta, fechaUltimaActualizacion FROM Producto WHERE stockActual " + cmb_comparacion.SelectedItem + ' ' + stock;

                DataTable table = conexion.ejecutar_consulta(sql);
                ReportDataSource ds = new ReportDataSource("stockProductos", table);
                //ReportParameter[] parametros = new ReportParameter[1];
                //parametros[0] = new ReportParameter("restriccion", stringRestriccion);

                //rv_stockProductos.LocalReport.SetParameters(parametros);
                rv_stockProductos.LocalReport.DataSources.Clear();
                rv_stockProductos.LocalReport.DataSources.Add(ds);
                rv_stockProductos.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
            }
        }

        private void btn_limpiarTab3_Click(object sender, EventArgs e)
        {
            cmb_comparacion.SelectedIndex = -1;
            txt_stock.Clear();
            rv_stockProductos.Clear();
        }

        private void rv_stockProductos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
