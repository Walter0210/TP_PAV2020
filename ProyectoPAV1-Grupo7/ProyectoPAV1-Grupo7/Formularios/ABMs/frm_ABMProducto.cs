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
    public partial class frm_ABMProducto : Form
    {
        public frm_ABMProducto()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //boton cerrar
        private void btnCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        //Inicio de VENTANA
        private void frm_ABMProducto_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            CargarGrilla();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxCodigoProducto.Text = "";
            txtBoxDescripcion.Text = "";
            txtBoxStockActual.Text = "";
            txtBoxPrecioCompra.Text = "";
            txtBoxPrecioVenta.Text = "";
            dateUltiAct.Text = "";
        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Producto";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrProducto.DataSource = tabla;

        }

        //Control De existencia de producto.
        private bool ExisteProducto(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrProducto.Rows.Count; i++)
            {
                if (dgrProducto.Rows[i].Cells["Cuit"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe un producto con ese Codigo");
                    break;

                }
            }
            return resultado;

        }

        //Guardar en base de datos.
        private bool GuardarProductoBD(Producto producto)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "INSERT INTO Estacion VALUES ('" + producto.Codigo + "','" + producto.Descripcion + "','" + producto.StockActual + "','" + producto.PrecioCompra + "','" + producto.PrecioVenta + "';'" + producto.UltimaFechaActStock + "' )";

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
            Producto producto = ObtenerDatosProducto();
            if (CargoCampos(producto) && ExisteEstacion(producto.Codigo).Equals(false))
            {
                bool resultado = GuardarEstacionBD(producto);
                if (resultado)
                {
                    MessageBox.Show("Estacion cargada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCodigoProducto.Focus();
                }
            }

        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private Producto ObtenerDatosEstacion()
        {
            //VARIABLES DE CONTROL
            string Codigo = txtBoxCodigoProducto.Text.Trim();
            string Descripcion = txtBoxDescripcion.Text.Trim();
            string StockActual = txtBoxStockActual.Text.Trim();
            string PrecioCompra = txtBoxPrecioCompra.Text.Trim();
            string PrecioVenta = txtBoxPrecioVenta.Text.Trim();
            DateTime fechaUltimaActualizacion = DateTime.Parse(dateUltiAct.Text);
            
            Producto est = new Producto(int.Parse(Codigo), Descripcion, int.Parse(StockActual), int.Parse(PrecioCompra), int.Parse(PrecioVenta), fechaUltimaActualizacion);

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
    }
}
