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
    public partial class frm_EstadisticaGananciaProducto : Form
    {
        public frm_EstadisticaGananciaProducto()
        {
            InitializeComponent();
        }

        private void frm_EstadisticaGananciaProducto_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select P.descripcion as 'producto', P.precioCompra, P.precioVenta, "
                                + "(P.precioVenta - P.precioCompra) as 'ganancia', ROUND(((P.precioVenta - P.precioCompra) * 100.0 / P.precioCompra), 2) as 'porcentajeGanancia'"
                                   + " from Producto P";
                DataTable tablaGananciaProductos = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosGananciaProducto", tablaGananciaProductos);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                this.Dispose();
            }
        }
    }
}
