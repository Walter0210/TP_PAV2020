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
        private bool fechas = false;

        public frm_ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void frm_ListadoEmpleados_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.reportViewer1.RefreshReport();
        }

        private void LimpiarCampos()
        {
            txt_legajo.Text = "";
            txt_legajo.Text = "";
            dateTime_desde.Text = "";
            dateTime_hasta.Text = "";
            chk_habilitarFechas.Checked = fechas;
            chk_habilitarFechas.CheckState = CheckState.Unchecked;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            buscarEmpleados();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            int legajo = 0;
            int dni = 0;

            if (txt_legajo.Text.ToString().Trim() != "" || txt_dni.Text.ToString().Trim() != "")
            {
                if (txt_legajo.Text.ToString().Trim() != "")
                {
                    legajo = int.Parse(txt_legajo.Text.ToString());
                }

                if (txt_dni.Text.ToString().Trim() != "")
                {
                    dni = int.Parse(txt_dni.Text.ToString());
                }  
            
            MessageBox.Show("Legajo: " + legajo + "DNI: " +  dni);

            DataTable tablaEmpleados = FiltrarTabla(legajo, dni);

            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tablaEmpleados);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un legajo o DNI");
                buscarEmpleados();
            }
            
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
                                    + ", E.fechaNacimiento"
                                    + ", E.fechaAlta"
                                    + ", J.nombre + ' ' + J.apellido as 'Jefe'"
                                    + "from Empleado E left join TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento "
                                                     + "left join Empleado J on E.legajoSuperior = J.legajo";

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosEmpleados", tablaEmpleados);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                this.Dispose();
            }
        }

        private DataTable FiltrarTabla(int legajo, int dni)
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
           
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select E.legajo"
                                    + ", E.nombre"
                                    + ", E.apellido"
                                    + ", TD.nombre as 'tipodni'"
                                    + ", E.nroDoc as 'dni'"
                                    + ", E.fechaNacimiento"
                                    + ", E.fechaAlta"
                                    + ", J.nombre + ' ' + J.apellido as 'Jefe'"
                                    + "from Empleado E left join TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento "
                                                     + "left join Empleado J on E.legajoSuperior = J.legajo "
                                    + "where " + legajoEmpleado + dniEmpleado;

                DataTable tablaEmpleados = conexion.ejecutar_consulta(consulta);
                return tablaEmpleados;
            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                
                this.Dispose();
                
            }
            return vacio;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_habilitarFechas.Checked == false)
            {
                chk_habilitarFechas.Checked = true; 
            }
            else
            {
                chk_habilitarFechas.Checked = false;
            }
        }
    }
}
