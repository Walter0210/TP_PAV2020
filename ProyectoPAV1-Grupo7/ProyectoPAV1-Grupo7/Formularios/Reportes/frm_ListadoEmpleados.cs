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
    public partial class frm_ListadoEmpleados : Form
    {
        //private bool fechas = false;
        private bool eligioFechaDesde = false;
        private bool eligioFechaHasta = false;
        private string where = string.Empty;

        public frm_ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void frm_ListadoEmpleados_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {
            buscarEmpleados();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarEmpleados();
        }

        private void buscarEmpleados()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select E.legajo"
                                    + ", E.nombre"
                                    + ", E.apellido"
                                    + ", TD.nombre as 'tipodni'"
                                    + ", E.nroDoc as 'dni'"
                                    + ", CONVERT (char, E.fechaNacimiento, 103) as 'fechaNacimiento'"
                                    + ", CONVERT (char, E.fechaAlta, 103) as 'fechaAlta'"
                                    + ", J.nombre + ' ' + J.apellido as 'Jefe'"
                                    + "from Empleado E left join TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento "
                                                     + "left join Empleado J on E.legajoSuperior = J.legajo "
                                    + where;

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosEmpleados", tablaEmpleados);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                where = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                //this.Dispose();
            }
        }

        /*private DataTable FiltrarTabla(int legajo, int dni)
        {
            DataTable vacio = new DataTable();
            string legajoEmpleado = "";
            string dniEmpleado = "";

            if (legajo != 0)
            {
                if (dni == 0)
                {
                    legajoEmpleado = "E.legajo = " + legajo.ToString();
                }
                else
                {
                    legajoEmpleado = "E.legajo = " + legajo.ToString() + " or ";
                }
                
            }

            if (dni != 0)
            {
                dniEmpleado = "E.nroDoc = " + dni.ToString();
            }


            buscarEmpleados();
        }*/

        private void dateTime_desde_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaDesde = true;
        }

        private void dateTime_hasta_ValueChanged(object sender, EventArgs e)
        {
            eligioFechaHasta = true;
        }

        private void ArmarStringFiltros()
        {
            string format = "yyyy-MM-dd";
            
            if (txt_legajo.Text.ToString().Trim() != "" || txt_dni.Text.ToString().Trim() != "")
            {
                if (txt_legajo.Text.ToString().Trim() != "")
                {
                    if (txt_dni.Text.ToString().Trim() == "")
                    {
                        where = "WHERE E.legajo = " + txt_legajo.Text.ToString();
                    }
                    else
                    {
                        where = "WHERE E.legajo = " + txt_legajo.Text.ToString() + " OR E.nroDoc = " + txt_dni.Text.ToString();
                    }
                }

                if (txt_dni.Text.ToString().Trim() != "")
                {
                    where = "WHERE E.nroDoc = " + txt_dni.Text.ToString();
                }
              
                if ((where.Contains("WHERE E.legajo = ") || where.Contains("WHERE E.nroDoc = ")) && eligioFechaDesde || eligioFechaHasta)
                {
                    where += " AND E.fechaAlta BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
            }
            else if (where == string.Empty && eligioFechaDesde || eligioFechaHasta)
            {
                where = "WHERE E.fechaAlta BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                if ((where.Contains("WHERE E.legajo = ") || where.Contains("WHERE E.nroDoc = ")))
                {
                    where += " AND E.fechaAlta BETWEEN " + "'" + dateTime_desde.Value.ToString(format) + "'" + " AND " + "'" + dateTime_hasta.Value.ToString(format) + "'";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_legajo.Text = "";
            txt_dni.Text = "";
            dateTime_desde.Value = DateTime.Now;
            dateTime_hasta.Value = DateTime.Now;
            eligioFechaDesde = false;
            eligioFechaHasta = false;
            where = string.Empty;

            buscarEmpleados();
        }
    }
}
