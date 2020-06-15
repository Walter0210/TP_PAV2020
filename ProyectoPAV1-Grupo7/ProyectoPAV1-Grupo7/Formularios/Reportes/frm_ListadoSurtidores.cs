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
    public partial class frm_ListadoSurtidores : Form
    {
        private string where = string.Empty;

        public frm_ListadoSurtidores()
        {
            InitializeComponent();
        }

        private void frm_ListadoSurtidores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            cargarCombos();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarSurtidores();
        }

        private void buscarSurtidores()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select S.numeroSurtidor as 'numSurtidor', E.razonSocial as 'estacion' , Estado.nombre as 'estado', TC.nombre as 'tipoCombustible'"
                                    + "from Surtidor S join Estado on S.idEstado = Estado.idEstado "
                                                    + "join Estacion E on S.cuit = E.CUIT "
                                                    + "join TipoCombustible TC on S.idTipoCombustible = TC.idTipoCombustible "
                                    + where;

                DataTable tablaSurtidores = conexion.ejecutar_consulta(consulta);
                ReportDataSource ds = new ReportDataSource("DatosSurtidores", tablaSurtidores);

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

        private void ArmarStringFiltros()
        {
            if (cmb_Estacion.SelectedIndex != -1 || cmb_Estado.SelectedIndex != -1 || cmb_TipoCombustible.SelectedIndex != -1)
            {
                if (cmb_Estacion.SelectedIndex != -1)
                {
                    // Si seleccione únicamente Estacion
                    if (cmb_Estado.SelectedIndex == -1 && cmb_TipoCombustible.SelectedIndex == -1)
                    {
                        where = "WHERE E.razonSocial like '" + cmb_Estacion.SelectedValue.ToString() + "'";
                    }
                    else
                    {
                        // Si seleccione las 3 opciones
                        if (cmb_Estado.SelectedIndex != -1 && cmb_TipoCombustible.SelectedIndex != -1)
                        {
                            where = "WHERE E.razonSocial like '" + cmb_Estacion.SelectedValue.ToString() + "' AND Estado.nombre like '" + cmb_Estado.SelectedValue.ToString() + "' AND TC.nombre like '" + cmb_TipoCombustible.SelectedValue.ToString() + "'";
                        }
                        else
                        {
                            // Si seleccione Estacion y Estado
                            if (cmb_Estado.SelectedIndex != -1)
                            {
                                where = "WHERE E.razonSocial like '" + cmb_Estacion.SelectedValue.ToString() + "' AND Estado.nombre like '" + cmb_Estado.SelectedValue.ToString() + "'";
                            }
                            // Si seleccione Estacion y Tipo Combustible
                            if (cmb_TipoCombustible.SelectedIndex != -1)
                            {
                                where = "WHERE E.razonSocial like '" + cmb_Estacion.SelectedValue.ToString() + "' AND TC.nombre like '" + cmb_TipoCombustible.SelectedValue.ToString() + "'";
                            }
                        }
                    }
                }

                // Si NO SELECCIONE Estacion y seleccione Estado
                if (cmb_Estacion.SelectedIndex == -1 && cmb_Estado.SelectedIndex != -1)
                {
                    // Si solo seleccione Estado
                    if (cmb_TipoCombustible.SelectedIndex == -1)
                    {
                        where = "WHERE Estado.nombre like '" + cmb_Estado.SelectedValue.ToString() + "'";
                    }
                    // Si solo seleccione Estado y Tipo Combustible
                    else
                    {
                        where = "WHERE Estado.nombre like '" + cmb_Estado.SelectedValue.ToString() + "' AND TC.nombre = '" + cmb_TipoCombustible.SelectedValue.ToString() + "'";
                    }
                }
                // Si NO SELECCIONE Estacion ni Estado y solo Tipo Combustible
                if (cmb_Estacion.SelectedIndex == -1 && cmb_Estado.SelectedIndex == -1 && cmb_TipoCombustible.SelectedIndex != -1)
                {
                    where = "WHERE TC.nombre like '" + cmb_TipoCombustible.SelectedValue.ToString() + "'";
                }
            }
                
        }

        private void cargarCombos()
        {
            // ESTACION
            cmb_Estacion.DataSource = buscarEstaciones();
            cmb_Estacion.DisplayMember = "razonSocial";
            cmb_Estacion.ValueMember = "razonSocial";
            cmb_Estacion.SelectedIndex = -1;

            // ESTADOS
            cmb_Estado.DataSource = buscarEstados();
            cmb_Estado.DisplayMember = "nombre";
            cmb_Estado.ValueMember = "nombre";
            cmb_Estado.SelectedIndex = -1;

            // TIPO COMBUSTIBLES
            cmb_TipoCombustible.DataSource = buscarTipoCombustibles();
            cmb_TipoCombustible.DisplayMember = "nombre";
            cmb_TipoCombustible.ValueMember = "nombre";
            cmb_TipoCombustible.SelectedIndex = -1;
        }

        private DataTable buscarEstaciones()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT * FROM Estacion";
                DataTable tabla = conexion.ejecutar_consulta(sql);
                return tabla;

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                DataTable vacio = new DataTable();
                return vacio;
            }
        }

        private DataTable buscarEstados()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT * FROM Estado";
                DataTable tabla = conexion.ejecutar_consulta(sql);
                return tabla;

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                DataTable vacio = new DataTable();
                return vacio;
            }
        }

        private DataTable buscarTipoCombustibles()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string sql = "SELECT * FROM TipoCombustible";
                DataTable tabla = conexion.ejecutar_consulta(sql);
                return tabla;

            }
            catch
            {
                MessageBox.Show("Error de Base de Datos");
                DataTable vacio = new DataTable();
                return vacio;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarStringFiltros();
            buscarSurtidores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_Estacion.SelectedIndex = -1;
            cmb_Estado.SelectedIndex = -1;
            cmb_TipoCombustible.SelectedIndex = -1;
            where = string.Empty;
            buscarSurtidores();
        }
    }

}
