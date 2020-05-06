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
        //Inicio de VENTANA
        private void frm_ABMEstacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtFechaUltimaActualizacion.Text = DateTime.Today.ToString();

            CargarGrilla();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxCodigo.Text = "";
            txtBoxDescripcion.Text = "";
            txtBoxStockActual.Text = "";
            txtBoxPrecioCompra.Text = "";
            txtBoxPrecioVenta.Text = "";
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtBoxCodigo.Enabled = false;
            txtFechaUltimaActualizacion.Enabled = false;

        }

        //FUNCION CARGAR GRILLA
        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Producto";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrProducto.DataSource = tabla;

        }

        //Control De existencia de Producto.
        private bool ExisteProducto(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrProducto.Rows.Count; i++)
            {
                if (dgrProducto.Rows[i].Cells["Cuit"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe un producto con ese CODIGO");
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
                string sql = "INSERT INTO Producto VALUES ('" + producto.Descripcion + "','" + producto.StockActual + "','" + producto.PrecioCompra + "','" + producto.PrecioVenta + "','" + producto.UltimaFechaActStock + "' )";

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
            if (CargoCampos(producto))
            {
                bool resultado = GuardarProductoBD(producto);
                if (resultado)
                {
                    MessageBox.Show("Producto cargado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCodigo.Focus();
                }
            }

        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private Producto ObtenerDatosProducto()
        {
            //VARIABLES DE CONTROL
            string Codigo = txtBoxCodigo.Text.Trim();
            string Descripcion = txtBoxDescripcion.Text.Trim();
            string StockActual = txtBoxStockActual.Text.Trim();
            string PrecioCompra = txtBoxPrecioCompra.Text.Trim();
            string PrecioVenta = txtBoxPrecioVenta.Text.Trim();
            DateTime fechaHabilitacion = DateTime.Parse(txtFechaUltimaActualizacion.Text.ToString());
            if (PrecioCompra.Equals("") || PrecioVenta.Equals("") || StockActual.Equals(""))
            {
                PrecioCompra = "0";
                PrecioVenta = "0";
                StockActual = "0";
            }
            Producto prod = new Producto(Descripcion, int.Parse(StockActual), int.Parse(PrecioCompra), int.Parse(PrecioVenta), fechaHabilitacion);

            return prod;
        }

        //Valida datos obligatorios
        private bool CargoCampos(Producto producto)
        {
            bool resultado = true;
            if (producto.Descripcion.Equals("") || producto.StockActual.Equals(0) || producto.PrecioCompra.Equals(0) || producto.PrecioVenta.Equals(0))
            {
                resultado = false;
                MessageBox.Show("Descricion, Stock Actual, Precio Compra, Precio Venta son obligatorios.");

            }

            return resultado;
        }

        //Obtener producto de Base de datos
        private Producto ObtenerProducto(int Codigo)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM Producto WHERE idProducto like '" + Codigo + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            txtBoxCodigo.Text = tabla.Rows[0]["idProducto"].ToString();
            string descripcion = tabla.Rows[0]["descripcion"].ToString();
            int stockActual = int.Parse(tabla.Rows[0]["stockActual"].ToString());
            int precioCompra = int.Parse(tabla.Rows[0]["precioCompra"].ToString());
            int precioVenta = int.Parse(tabla.Rows[0]["precioVenta"].ToString());
            //DateTime fecha = DateTime.Parse(tabla.Rows[0]["fechaHabilitacion"].ToString());
            DateTime fecha = Convert.ToDateTime(tabla.Rows[0]["fechaUltimaActualizacion"].ToString());
            Producto producto = new Producto(descripcion , stockActual, precioCompra, precioVenta, fecha);
            return producto;


        }

        //Seleccion de item en grilla
        private void dgrProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            LimpiarCampos();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            txtBoxCodigo.Enabled = false;
            DataGridViewRow fila = dgrProducto.Rows[indice];
            string Codigo = fila.Cells["Codigo"].Value.ToString();
            Producto producto = ObtenerProducto(int.Parse(Codigo));
            CargarCampos(producto);
        }

        //Cargar campos de TEXTO automaticamente.
        private void CargarCampos(Producto producto)
        {
            txtBoxDescripcion.Text = producto.Descripcion;
            txtBoxStockActual.Text = producto.StockActual.ToString();
            txtBoxPrecioCompra.Text = producto.PrecioCompra.ToString();
            txtBoxPrecioVenta.Text = producto.PrecioVenta.ToString();
            txtFechaUltimaActualizacion.Text = producto.UltimaFechaActStock.ToString();

        }

        //Actualizar datos en bd 
        private bool ActualizarProductoBD(Producto producto)
        {

            producto.UltimaFechaActStock = DateTime.Today;
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "UPDATE Producto SET descripcion = '" + producto.Descripcion + "', stockActual = '" + producto.StockActual + "',precioCompra ='" + producto.PrecioCompra + "',precioVenta ='"+ producto.PrecioVenta + "',fechaUltimaActualizacion ='" + producto.UltimaFechaActStock + "' WHERE idProducto like '" + producto.Codigo + "'";

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
            Producto producto = ObtenerDatosProducto();
            if (CargoCampos(producto))
            {
                producto.Codigo = int.Parse(txtBoxCodigo.Text);
                bool resultado = ActualizarProductoBD(producto);
                if (resultado)
                {
                    MessageBox.Show("Producto modificado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCodigo.Focus();
                }
            }
        }

        //Borrar producto de base de datos
        private bool BorrarProductoBD(Producto producto)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "DELETE FROM Producto WHERE idProducto = '" + producto.Codigo + "'";

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
            Producto producto = ObtenerDatosProducto();
            if (CargoCampos(producto))
            {
                producto.Codigo = int.Parse(txtBoxCodigo.Text);
                bool resultado = BorrarProductoBD(producto);
                if (resultado)
                {
                    MessageBox.Show("Producto eliminado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxCodigo.Focus();
                }
            }
        }
    }
}
