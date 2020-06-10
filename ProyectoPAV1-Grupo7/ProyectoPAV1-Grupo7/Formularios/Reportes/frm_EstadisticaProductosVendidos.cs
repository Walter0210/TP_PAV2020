using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV1_Grupo7.Clases;
using Microsoft.Reporting.WinForms;

namespace ProyectoPAV1_Grupo7.Formularios.Reportes
{
    public partial class frm_EstadisticaProductosVendidos : Form
    {
        public frm_EstadisticaProductosVendidos()
        {
            InitializeComponent();
        }

        private void frm_EstadisticaProductosVendidos_Load(object sender, EventArgs e)
        {

            this.reportViewerProductos.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"SELECT CONVERT(varchar, P.descripcion) as Producto, SUM(CONVERT(INT, TP.cantidad)) as Cantidad"
                                   + " FROM TicketXProducto TP JOIN Producto P on TP.idProducto = P.idProducto"
                                    + " GROUP BY P.descripcion";
                DataTable tablaProductosMasVendidos = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosProductosMasVendidos", tablaProductosMasVendidos);
                reportViewerProductos.LocalReport.DataSources.Clear();
                reportViewerProductos.LocalReport.DataSources.Add(ds);
                reportViewerProductos.LocalReport.Refresh();

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                this.Dispose();
            }
        }
    }
}
