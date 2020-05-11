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

namespace ProyectoPAV1_Grupo7.Formularios.ABMs
{
    public partial class frm_ABMSoporte : Form
    {
        public frm_ABMSoporte(string nombre)
        {
            InitializeComponent();
            this.Text = nombre;
            CargarGrilla(nombre);
        }

        private void CargarGrilla(string nombreTabla)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM " + nombreTabla;
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrSoporte.DataSource = tabla;
        }

        //Seleccion de item en grilla
        private void dgrSoporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            LimpiarCampos();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            txtBoxNombre.Enabled = true;
            DataGridViewRow fila = dgrSoporte.Rows[indice];
            string id = fila.Cells["ID"].Value.ToString();
            NivelUrgencia urgencia = ObtenerUrgencia("Urgencia", "idUrgencia", int.Parse(id));
            CargarCampos(urgencia);
        }

        //Obtener estacion de Base de datos
        private NivelUrgencia ObtenerUrgencia(string nombreTabla, string propiedad, int id )
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM " + nombreTabla + " WHERE " + propiedad + " like '" + id + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            string nombre = tabla.Rows[0]["nombre"].ToString();
            int numeroID = int.Parse(tabla.Rows[0][propiedad].ToString());

            NivelUrgencia urgencia = new NivelUrgencia(numeroID, nombre);
            return urgencia;
        }

        //Cargar campos de TEXTO automaticamente.
        private void CargarCampos(NivelUrgencia urgencia)
        {
            txtBoxNombre.Text = urgencia.Nombre.ToString();
            txtCodigo.Text = urgencia.IdEstado.ToString();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxNombre.Text = "";
            txtCodigo.Text = "";
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CLICK boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                bool resultado = BorrarEstacionBD(urgencia, "Urgencia");
                if (resultado)
                {
                    MessageBox.Show("Urgencia Eliminada con exito");
                    LimpiarCampos();
                    CargarGrilla("Urgencia");
                    txtBoxNombre.Focus();
                }
            }
        }

        //Borrar estacion de base de datos
        private bool BorrarEstacionBD(NivelUrgencia urgencia, string nombreTabla)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "DELETE FROM " + nombreTabla +" WHERE idUrgencia = '" + urgencia.IdEstado + "'";

                conexion.borrar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos: Base de datos corrompida");
            }
            return resultado;
        }

        //Guardar en base de datos.
        private bool GuardarUrgenciaBD(NivelUrgencia urgencia)
        {
            bool resultado = false;

            Random random = new Random();
            int id = random.Next(100, 1000);
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "INSERT INTO Urgencia VALUES ('"+ id + "', '" + urgencia.Nombre + "' )";

                conexion.insertar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos: Base de datos corrompida");
            }
            return resultado;
        }

        //Actualizar datos en bd 
        private bool ActualizarUrgenciaBD(NivelUrgencia urgencia)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "UPDATE Urgencia SET nombre = ' " + urgencia.Nombre + "' WHERE idUrgencia = ' " + urgencia.IdEstado + " '";

                conexion.modificar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos: Base de datos corrompida");
            }
            return resultado;
        }

        //Control De existencia de estacion.
        private bool ExisteUrgencia(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrSoporte.Rows.Count; i++)
            {
                if (dgrSoporte.Rows[i].Cells["ID"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe una urgencia con ese id");
                    break;

                }
            }
            return resultado;

        }

        //Valida datos obligatorios
        private bool CargoCampos(NivelUrgencia urgencia)
        {
            bool resultado = true;
            if (urgencia.Nombre.Equals(""))
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");

            }

            return resultado;
        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private NivelUrgencia ObtenerDatosUrgencia()
        {
            //VARIABLES DE CONTROL
            string nombre = txtBoxNombre.Text.Trim();

            NivelUrgencia urg = new NivelUrgencia(nombre);

            return urg;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                bool resultado = GuardarUrgenciaBD(urgencia);
                if (resultado)
                {
                    MessageBox.Show("Urgencia cargada con exito");
                    LimpiarCampos();
                    CargarGrilla("Urgencia");
                    txtBoxNombre.Focus();
                }
            }

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                urgencia.IdEstado = int.Parse(txtCodigo.Text);

                bool resultado = ActualizarUrgenciaBD(urgencia);
                if (resultado)
                {
                    MessageBox.Show("Urgencia Modificada con exito");
                    LimpiarCampos();
                    CargarGrilla("Urgencia");
                    txtBoxNombre.Focus();
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                urgencia.IdEstado = int.Parse(txtCodigo.Text);
                bool resultado = BorrarEstacionBD(urgencia, "Urgencia");
                if (resultado)
                {
                    MessageBox.Show("Urgencia Eliminada con exito");
                    LimpiarCampos();
                    CargarGrilla("Urgencia");
                    txtBoxNombre.Focus();
                }
            }
        }

        private void frm_ABMSoporte_Load(object sender, EventArgs e)
        {

        }
    }
}
