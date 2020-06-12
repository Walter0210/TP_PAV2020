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
    public partial class frm_ListadoTickets : Form
    {
        public frm_ListadoTickets()
        {
            InitializeComponent();
        }

        private void frm_ListadoTickets_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select T.numTicket"
                                    + ", T.fecha as 'Fecha'"
                                    + ", E.razonSocial as 'Estacion'"
                                    + ", T.numeroSurtidor as 'NumSurtidor'"
                                    + ", T.cantidad as 'Cantidad'"
                                    + ", UM.nombre as 'UnidadMedida'"
                                    + ", T.observacion as 'Observacion'"
                                    + "from Ticket T join Estacion E on T.cuit = E.CUIT join UnidadMedida UM on T.idUnidadMedida = UM.idUnidadMedida";
                DataTable tablaTickets = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosTickets", tablaTickets);
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
