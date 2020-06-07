using Microsoft.Reporting.WinForms;
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
    public partial class frm_EstadisticaOrdenesCompra : Form
    {
        public frm_EstadisticaOrdenesCompra()
        {
            InitializeComponent();
        }

        private void frm_estadisticaOrdenesCompra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = frm_ConsultaOrdenCompra.ObtenerEstadisticaOrdenesCompra();

            ReportDataSource ds = new ReportDataSource("DatosEstadisticaOrdenesCompra", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
