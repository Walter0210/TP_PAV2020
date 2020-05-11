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
                if (dgrEmpleado.Rows[i].Cells["Legajo"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe una empleado con ese legajo");
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
            try
            {
                string sql = "INSERT INTO Empleado VALUES ('" + empleado.Nombre + "','" + empleado.Apellido + "','" + empleado.TipoDoc + "','" + empleado.NroDoc + "','" + empleado.FechaNacimiento + "','" + empleado.FechaAlta + "','" + empleado.LegajoSuperior + "' )";

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
            string sql = "SELECT * FROM Empleado";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            tbxLegSup.DataSource = tabla;
            tbxLegSup.DisplayMember = "legajo";
            tbxLegSup.ValueMember = "legajo";
            tbxLegSup.SelectedIndex = -1;
        }

        //BOTON GUARDAR
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Empleado empleado = ObtenerDatosEmpleado();
            if (CargoCampos(empleado) && ExisteEmpleado(empleado.Legajo).Equals(false))
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

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private Empleado ObtenerDatosEmpleado()
        {
            //VARIABLES DE CONTROL
            string nombre = tbxNombre.Text.Trim();
            string apellido = tbxApellido.Text.Trim();
            string tipoDoc = cmbTipoDoc.SelectedValue.ToString();
            string documento = tbxDocumento.Text.Trim();
            string fechaNacimiento = dtpFechaNac.Text;
            string fechaAlta = dtpFechaAlta.Text; 
            string legajoSuperior = tbxLegSup.SelectedValue.ToString();
            if (documento.Equals("") || tipoDoc.Equals("") || legajoSuperior.Equals(""))
            {
                tipoDoc = "0";
                documento = "0";
                legajoSuperior = "1";
            }
            Empleado emp = new Empleado(nombre, apellido, int.Parse(tipoDoc), int.Parse(documento), DateTime.Parse(fechaNacimiento), DateTime.Parse(fechaAlta), int.Parse(legajoSuperior));

            return emp;
        }

        //Valida datos obligatorios
        private bool CargoCampos(Empleado empleado)
        {
            bool resultado = true;
            if (empleado.NroDoc.Equals(0) || empleado.Nombre.Equals("") || empleado.Apellido.Equals("") || empleado.LegajoSuperior.Equals(0))
            {
                resultado = false;
                MessageBox.Show("Documento, nombre y apellido son obligatorios");

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
                Empleado empleado = ObtenerEmpleado(int.Parse(leg));
                CargarCampos(empleado);
            }
        }

        private Empleado ObtenerEmpleado(int legajo)
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

            }
            else
            {
                legajoSup = 0;
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
            try
            {
                string sql = "UPDATE Empleado SET Nombre = '" + empleado.Nombre + "', Apellido = '" + empleado.Apellido +
                    "', TipoDoc ='" + empleado.TipoDoc + "', NroDoc ='" + empleado.NroDoc + "', FechaNacimiento ='" + empleado.FechaNacimiento + "', FechaAlta ='" + empleado.FechaAlta +
                    "', LegajoSuperior ='" + empleado.LegajoSuperior + "' WHERE Legajo like '" + legajo + "'";

                conexion.modificar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado empleado = ObtenerDatosEmpleado();
            string leg = tbxLegajo.Text.Trim();

            if (CargoCampos(empleado))
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
            Empleado empleado = ObtenerDatosEmpleado();
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
    }
}
