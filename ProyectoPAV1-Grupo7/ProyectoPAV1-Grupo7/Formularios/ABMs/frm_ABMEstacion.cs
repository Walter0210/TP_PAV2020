using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios
{
    public partial class frm_ABMEstacion : Form
    {

        public frm_ABMEstacion()
        {
            InitializeComponent();
        }
        
        //boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Inicio de VENTANA
        private void frm_ABMEstacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtFechaHab.Text = DateTime.Today.ToString();

            CargarGrilla();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxCalle.Text = "";
            txtBoxCuit.Text = "";
            txtBoxNumero.Text = "";
            txtBoxRazonSocial.Text = "";
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtBoxCuit.Enabled = true;
        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrEstacion.DataSource = tabla;

        }

        //Control De existencia de estacion.
        private bool ExisteEstacion(int Criterio)
        {   
            bool resultado = false;
            for (int i = 0; i < dgrEstacion.Rows.Count; i++)
            {
                if (dgrEstacion.Rows[i].Cells["Cuit"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe una estacion con ese CUIT");
                    break;

                }
            }
            return resultado;

        }

        //Guardar en base de datos.
        private bool GuardarEstacionBD(Estacion estacion)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "INSERT INTO Estacion VALUES ('"+ estacion.Cuit+"','"+ estacion.RazonSocial+"','"+ estacion.Calle+"','"+ estacion.Nro +"','"+estacion.FechaHabilitacion+"' )";
                
                conexion.insertar(sql);
                
                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        //BOTON GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estacion estacion = ObtenerDatosEstacion();
            if (CargoCampos(estacion) && ExisteEstacion(estacion.Cuit).Equals(false))
            {
                bool resultado = GuardarEstacionBD(estacion);
                if (resultado)
                {
                    MessageBox.Show("Estacion cargada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCuit.Focus();
                }
            }
        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private Estacion ObtenerDatosEstacion()
        {
            //VARIABLES DE CONTROL
            string CUIT = txtBoxCuit.Text.Trim();
            string razonSocial = txtBoxRazonSocial.Text.Trim();
            string calle = txtBoxCalle.Text.Trim();
            string numero = txtBoxNumero.Text.Trim();
            DateTime fechaHabilitacion = DateTime.Parse(txtFechaHab.Text.ToString());
            if (CUIT.Equals("") || numero.Equals(""))
            {
                CUIT = "0";
                numero = "0";
            }
            Estacion est = new Estacion(int.Parse(CUIT), razonSocial, calle, int.Parse(numero), fechaHabilitacion);

            return est;
        }

        //Valida datos obligatorios
        private bool CargoCampos(Estacion estacion)
        {
            bool resultado = true;
            if (estacion.Cuit.Equals(0) || estacion.RazonSocial.Equals("") || estacion.Calle.Equals(""))
            {
                resultado = false;
                MessageBox.Show("CUIT, razon social y calle son obligatorios");

            }

            return resultado;
        }

        //Obtener estacion de Base de datos
        private Estacion ObtenerEstacion(int CUIT)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Estacion WHERE CUIT like '" + CUIT + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            string razonSocial = tabla.Rows[0]["razonSocial"].ToString();
            string calle = tabla.Rows[0]["Calle"].ToString();
            int num = int.Parse(tabla.Rows[0]["Numero"].ToString());
            //DateTime fecha = DateTime.Parse(tabla.Rows[0]["fechaHabilitacion"].ToString());
            DateTime fecha = Convert.ToDateTime(tabla.Rows[0]["fechaHabilitacion"].ToString());
            Estacion estacion = new Estacion(CUIT, razonSocial, calle, num, fecha);
            return estacion;


        }

        //Seleccion de item en grilla
        private void dgrEstacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            LimpiarCampos();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            txtBoxCuit.Enabled = false;
            DataGridViewRow fila = dgrEstacion.Rows[indice];
            string CUIT = fila.Cells["CUIT"].Value.ToString();
            Estacion estacion = ObtenerEstacion(int.Parse(CUIT));
            CargarCampos(estacion);
        }

        //Cargar campos de TEXTO automaticamente.
        private void CargarCampos(Estacion estacion)
        {
            txtBoxCuit.Text = estacion.Cuit.ToString();
            txtBoxRazonSocial.Text = estacion.RazonSocial;
            txtBoxCalle.Text = estacion.Calle;
            txtBoxNumero.Text = estacion.Nro.ToString();
            txtFechaHab.Text = estacion.FechaHabilitacion.ToString();

        }

        //Actualizar datos en bd 
        private bool ActualizarEstacionBD(Estacion estacion)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "UPDATE Estacion SET CUIT = '" + estacion.Cuit + "', razonSocial = ' " + estacion.RazonSocial + "', calle = '" + estacion.Calle +
                    "', numero ='" + estacion.Nro + "',fechaHabilitacion ='" + estacion.FechaHabilitacion + "' WHERE CUIT like '" + estacion.Cuit + "'";

                conexion.modificar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        //CLICK boton Modificar.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Estacion estacion = ObtenerDatosEstacion();
            if (CargoCampos(estacion))
            {
                bool resultado = ActualizarEstacionBD(estacion);
                if(resultado)
                {
                    MessageBox.Show("Estacion Modificada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCuit.Focus();
                }
            }
        }

        //Borrar estacion de base de datos
        private bool BorrarEstacionBD(Estacion estacion)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "DELETE FROM Estacion WHERE CUIT = '" + estacion.Cuit + "'";

                conexion.borrar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos de persona: Base de datos corrompida");
            }
            return resultado;
        }

        //CLICK boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Estacion estacion = ObtenerDatosEstacion();
            if (CargoCampos(estacion))
            {
                bool resultado = BorrarEstacionBD(estacion);
                if (resultado)
                {   
                    MessageBox.Show("Estacion Eliminada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCuit.Focus();
                }
            }
        }
    }
}

