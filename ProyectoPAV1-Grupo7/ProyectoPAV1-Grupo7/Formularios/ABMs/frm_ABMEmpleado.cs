using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios
{
    public partial class frm_ABMEmpleado : Form
    {
        public frm_ABMEmpleado()
        {
            InitializeComponent();
        }

        //boton cerrar
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Inicio de VENTANA
        private void frm_ABMEmpleado_Load_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
            tbxLegajo.Enabled = false;
            tbxLegajo.Visible = false;
            lblLegajo.Visible = false;

            CargarGrilla();
            cargarComboTipoDocmento();
            cargarComboSupervisor();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            tbxNombre.Text = "";
            tbxApellido.Text = "";
            tbxDocumento.Text = "";
            tbxLegSup.Text = "";
        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT E.legajo, E.nombre, E.apellido, TD.nombre, E.nroDoc, E.fechaNacimiento, E.fechaAlta, E.legajoSuperior " + 
                "FROM Empleado E JOIN TipoDocumento TD on E.tipoDoc = TD.idTipoDocumento";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrEmpleado.DataSource = tabla;

        }

        //Control De existencia de empleado.
        private bool ExisteEmpleado(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrEmpleado.Rows.Count; i++)
            {
                if (dgrEmpleado.Rows[i].Cells["Documento"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe una empleado con ese documento");
                    break;
                }
            }
            return resultado;

        }

        //Guardar en base de datos.
        private bool GuardarEmpleadoBD(Empleado empleado)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            string format = "yyyy-MM-dd HH:mm:ss";
            try
            {
                string sql = "";
                string legSup = empleado.LegajoSuperior.ToString();
                if (empleado.LegajoSuperior.Equals(0))
                {
                    legSup = "NULL";
                }
                sql = "INSERT INTO Empleado VALUES ('" + empleado.Nombre + "','" + empleado.Apellido + "','" + empleado.TipoDoc + "','" + empleado.NroDoc + "','"
                        + empleado.FechaNacimiento.ToString(format) + "','" + empleado.FechaAlta.ToString(format) + "'," + legSup + ")";
                conexion.insertar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        private void cargarComboTipoDocmento()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM TipoDocumento";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            cmbTipoDoc.DataSource = tabla;
            cmbTipoDoc.DisplayMember = "nombre";
            cmbTipoDoc.ValueMember = "idTipoDocumento";
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void cargarComboSupervisor()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT E.nombre + ' ' + E.apellido as apeNom, E.legajo" +
                " FROM Empleado E";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            tbxLegSup.DataSource = tabla;
            tbxLegSup.DisplayMember = "apeNom";
            tbxLegSup.ValueMember = "legajo";
            tbxLegSup.SelectedIndex = -1;
        }

        //BOTON GUARDAR
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (cmbTipoDoc.SelectedIndex != -1 && tbxDocumento.Text != "" && dtpFechaAlta.Value != dtpFechaNac.Value && checkSupervisor.Checked == false && tbxLegSup.SelectedIndex != -1)
            {
                Empleado empleado = ArmarObjeto();
                if (ExisteEmpleado(empleado.Legajo).Equals(false))
                {
                    bool resultado = GuardarEmpleadoBD(empleado);
                    if (resultado)
                    {
                        MessageBox.Show("Empleado cargado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                        tbxNombre.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor complete los datos del nuevo empleado");
            }
        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private Empleado ArmarObjeto()
        {
            
            //VARIABLES DE CONTROL
            string nombre = tbxNombre.Text.Trim();
            string apellido = tbxApellido.Text.Trim();
            int tipoDoc = (int)cmbTipoDoc.SelectedValue;
            string documento = tbxDocumento.Text.Trim();
            DateTime fechaNacimiento = dtpFechaNac.Value;
            DateTime fechaAlta = dtpFechaAlta.Value;
            int legajoSuperior = 0;

            //Asiganacion de Supervisor
            if (tbxLegSup.SelectedIndex != -1)
            {
                legajoSuperior = (int)tbxLegSup.SelectedValue;
            }
            
            Empleado emp = new Empleado(nombre, apellido, tipoDoc, int.Parse(documento), fechaNacimiento, fechaAlta, legajoSuperior);

            return emp;
        }

        //Valida datos obligatorios
        private bool CargoCampos(Empleado empleado)
        {
            bool resultado = true;
            if (tbxDocumento.Text.Trim().Equals(""))
            {
                resultado = false;
                MessageBox.Show("Documento y tipo de documento es obligatrio.");
            }
                return resultado;
        }
    
        private void dgrEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice != -1)
            {
                LimpiarCampos();
                btnModificar.Enabled = true;
                btnEliminarEmpleado.Enabled = true;
                btnGuardar.Enabled = false;
                tbxLegajo.Visible = true;
                lblLegajo.Visible = true;

                DataGridViewRow fila = dgrEmpleado.Rows[indice];
                string leg = fila.Cells["Legajo"].Value.ToString();
                Empleado empleado = ObtenerDatosEmpleado(int.Parse(leg));
                CargarCampos(empleado);
            }
        }

        private Empleado ObtenerDatosEmpleado(int legajo)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Empleado WHERE Legajo like '" + legajo + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            int legajoSup;

            string nombre = tabla.Rows[0]["Nombre"].ToString();
            string apellido = tabla.Rows[0]["Apellido"].ToString();
            int tipoDoc = (int)tabla.Rows[0]["TipoDoc"];
            int nrodoc = (int)tabla.Rows[0]["NroDoc"];
            string fechaNacimiento = tabla.Rows[0]["FechaNacimiento"].ToString();
            string fechaAlta = tabla.Rows[0]["FechaAlta"].ToString();

            int? legajoSuperior = tabla.Rows[0]["LegajoSuperior"] as int?;
            if(legajoSuperior.HasValue)
            {
                legajoSup = legajoSuperior.Value;
                checkSupervisor.Checked = false;
            }
            else
            {
                legajoSup = 0;
                checkSupervisor.Checked = true;
            }

            Empleado empleado = new Empleado(legajo, nombre, apellido, tipoDoc, nrodoc, DateTime.Parse(fechaNacimiento), DateTime.Parse(fechaAlta), legajoSup);
            return empleado;

        }

        //Cargar campos de TEXTO automaticamente.
        private void CargarCampos(Empleado empleado)
        {
            tbxLegajo.Visible = true;
            tbxLegajo.Text = empleado.Legajo.ToString();
            tbxNombre.Text = empleado.Nombre;
            tbxApellido.Text = empleado.Apellido;
            cmbTipoDoc.SelectedValue = empleado.TipoDoc.ToString();
            tbxDocumento.Text = empleado.NroDoc.ToString();
            dtpFechaNac.Text = empleado.FechaNacimiento.ToString();
            dtpFechaAlta.Text = empleado.FechaAlta.ToString();
            tbxLegSup.SelectedValue = empleado.LegajoSuperior.ToString();
        }

        //Actualizar datos empelado en BD 
        private bool ActualizarEmpleadoBD(Empleado empleado, int legajo)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            string format = "yyyy-MM-dd HH:mm:ss";
            string legSup;
            try
            {
                if (checkSupervisor.Checked)
                {
                    legSup = "NULL";
                }
                else
                {
                    legSup = empleado.LegajoSuperior.ToString();
                }
                string sql = "UPDATE Empleado SET Nombre = '" + empleado.Nombre + "', Apellido = '" + empleado.Apellido +
                    "', TipoDoc ='" + empleado.TipoDoc + "', NroDoc ='" + empleado.NroDoc + "', FechaNacimiento ='" + empleado.FechaNacimiento.ToString(format) + "', FechaAlta ='" + empleado.FechaAlta.ToString(format) +
                    "', LegajoSuperior = " + legSup + " WHERE Legajo like '" + legajo + "'";

                conexion.modificar(sql);
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona");
            }
            return resultado;
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado empleado = ArmarObjeto();
            string leg = tbxLegajo.Text.Trim();

            if (CargoCampos(empleado))
            {
                if (checkSupervisor.Checked == false && tbxLegSup.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elejir un supervisor");
                }
                else
                {
                    bool resultado = ActualizarEmpleadoBD(empleado, int.Parse(leg));
                    if (resultado)
                    {
                        MessageBox.Show("Empleado modificado con exito");
                        LimpiarCampos();
                        CargarGrilla();
                        tbxNombre.Focus();
                    }
                }
            }
        }

        //Borrar empleado en BD
        private bool BorrarEmpleadoBD(Empleado empleado, int legajo)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "DELETE FROM Empleado WHERE Legajo = '" + legajo + "'";

                conexion.borrar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado empleado = ArmarObjeto();
            string leg = tbxLegajo.Text.Trim();

            if (CargoCampos(empleado))
            {
                bool resultado = BorrarEmpleadoBD(empleado, int.Parse(leg));
                if (resultado)
                {
                    MessageBox.Show("Empleado eliminado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    tbxNombre.Focus();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VaciarGrilla(dgrEmpleado);
            Empleado empBuscado = new Empleado();
            ConexionBD conexion = new ConexionBD();

            string sql = "exec paBuscar '" + txtBoxBuscar.Text + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrEmpleado.DataSource = tabla;
            if (dgrEmpleado.Rows.Count > 0)
            {
                empBuscado = ObtenerDatosEmpleado((int)dgrEmpleado.Rows[0].Cells["Legajo"].Value);
                CargarCampos(empBuscado);
                btnModificar.Enabled = true;
                btnEliminarEmpleado.Enabled = true;
                btnGuardar.Enabled = false;
            }
            else
            {
                MessageBox.Show("La busqueda no obtuvo resultados");
            }
        }

        private void VaciarGrilla(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridView.Rows.Remove(row);

            }
        }

        private void checkSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSupervisor.Checked)
            {
                tbxLegSup.Enabled = false;
                tbxLegSup.SelectedIndex = -1;
            }
            else
            {
                tbxLegSup.Enabled = true;
            }
        }

        private void txtBoxBuscar_Click(object sender, EventArgs e)
        {
            txtBoxBuscar.Clear();
        }

        private void txtBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {   
            /*
            VaciarGrilla(dgrEmpleado);
            Empleado empBuscado = new Empleado();
            ConexionBD conexion = new ConexionBD();
            string sql = "exec paBuscar '" + txtBoxBuscar.Text + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrEmpleado.DataSource = tabla;
            if (dgrEmpleado.Rows.Count > 0)
            {
                empBuscado = ObtenerDatosEmpleado((int)dgrEmpleado.Rows[0].Cells["Legajo"].Value);
                CargarCampos(empBuscado);
            }
            */
        }
    }
}
