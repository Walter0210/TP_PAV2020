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

namespace ProyectoPAV1_Grupo7
{
    public partial class frm_ConsultaOrdenCompra : Form
    {
        // Declaro estas variables para poder ser accedidas
        private int OrdenSeleccionada = 0;
        private int DetalleSeleccionado = 0;
        private int CantidadSeleccionada = 0;

        public frm_ConsultaOrdenCompra()
        {
            InitializeComponent();
        }

        private void frm_ConsultaOrdenCompra_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        internal static DataTable ObtenerListadoTickets()
        {
            throw new NotImplementedException();
        }

        private void CargarGrilla()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra , OC.fecha, E.nombre + E.apellido AS apenom, S.razonSocial, OC.total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT ");

            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrOrdenCompra.DataSource = tabla;

        }

        private void dgrOrdenCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if(indice != -1)
            {
                DataGridViewRow fila = dgrOrdenCompra.Rows[indice];
                string numOrden = fila.Cells["Numero"].Value.ToString();
                OrdenSeleccionada = int.Parse(numOrden);
                CargarGrilla2(numOrden);

            }
        }

        private void dgrDetallesOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tomo los datos del detalle seleccionado para realizar el Update
            int indice = e.RowIndex;
            if (indice != -1)
            {
                DataGridViewRow fila = dgrDetallesOrden.Rows[indice];
                string descripcion = fila.Cells["Producto"].Value.ToString();
                int numDetalle = consultarIdProducto(descripcion);
                string cantidad = fila.Cells["Cantidad"].Value.ToString();
                DetalleSeleccionado = numDetalle;
                CantidadSeleccionada = int.Parse(cantidad);
            }
        }

        private int consultarIdProducto(string descripcion)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                string consulta = @"select idProducto from Producto stringWhere descripcion like '" + descripcion + "'";
                DataTable idProductoTable = conexion.ejecutar_consulta(consulta);
                int idProducto = int.Parse(idProductoTable.Rows[0][0].ToString());
                return idProducto;
            }
            catch (Exception)
            {
                MessageBox.Show("Error de consulta a Base de Datos");
                return 0;
            }
        }


        private void CargarGrilla2(string numOrden)
        {
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT DC.numOrdenCompra, P.descripcion, DC.cantidad, UM.nombre, P.precioCompra * DC.cantidad AS precitotal, UR.nombre"
                + " FROM DetalleOrdenCompra DC "
                + "JOIN Producto P ON DC.idProducto = P.idProducto "
                + "JOIN UnidadMedida UM ON DC.idUnidadMedida = UM.idUnidadMedida "
                + "JOIN Urgencia UR ON DC.idUrgencia = UR.idUrgencia " +
                "WHERE DC.numOrdenCompra = '" + numOrden + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrDetallesOrden.DataSource = tabla;

        }

        private int consultarStockActualProducto(int idProducto, ConexionBD conexion)
        {
            string consulta = "SELECT stockActual FROM Producto WHERE idProducto = " + idProducto;
            DataTable stockActualProducto = conexion.ejecutar_consulta(consulta);
            int stockActual = int.Parse(stockActualProducto.Rows[0][0].ToString());
            return stockActual;
        }

        private void actualizarStockActualProducto(int idProducto)
        {
            ConexionBD conexion = new ConexionBD();
            int stockActual = consultarStockActualProducto(idProducto, conexion);
            int nuevaCantidad = stockActual + CantidadSeleccionada;
            string sql = "UPDATE Producto SET stockActual = " + nuevaCantidad + " WHERE idProducto = " + idProducto;
            conexion.ejecutar_consulta(sql);
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Usted seleccionó Orden de Compra: " + OrdenSeleccionada + ", Detalle: " + DetalleSeleccionado + ", Cantidad: " + CantidadSeleccionada);
            if (OrdenSeleccionada != 0)
            {
                if (DetalleSeleccionado != 0 || CantidadSeleccionada != 0)
                {
                    try
                    {
                        Producto productoSeleccionado = new Producto(DetalleSeleccionado);
                        productoSeleccionado.actualizarStockActualProducto(CantidadSeleccionada);
                        MessageBox.Show("Pedido registrado correctamente!");
                        // Seteo en 0 las referencias para que no pueda registrar de nuevo el producto
                        OrdenSeleccionada = 0;
                        DetalleSeleccionado = 0;
                        CantidadSeleccionada = 0;
                        this.Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error de consulta a Base de Datos");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione producto de la Orden de Compra");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una Orden de Compra");
            }
        }

            // duplique la primera funcion para que sea publica y devuelva la tabla de tipo DataTable para usarlo en los reportes
            // en la otra funcion no permitia que sea static

        public static DataTable ObtenerListadoOrdenesCompra()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT ");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;

        }

        public static DataTable ObtenerListadoOrdenesCompraConFiltro(int solicitante)
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra as numeroOrdenCompra, OC.fecha as fecha, E.nombre + E.apellido AS legajo, S.razonSocial as cuitSolicitante, OC.total as total" +
                " FROM OrdenCompra OC JOIN Empleado E ON OC.legajo = E.legajo " +
                "JOIN Estacion S ON OC.cuitSolicitante = S.CUIT ");


            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;

        }

        public static DataTable ObtenerEstadisticaOrdenesCompraMeses()
        {
            ConexionBD conexion = new ConexionBD();

            string sql = string.Format("SELECT OC.numeroOrdenCompra as nroOrdenCompra, COUNT(DC.idProducto) as cantidad" +
                " FROM OrdenCompra OC JOIN DetalleOrdenCompra DC ON OC.numeroOrdenCompra = DC.numOrdenCompra " +
                "GROUP BY OC.numeroOrdenCompra");

            DataTable tabla = conexion.ejecutar_consulta(sql);

            return tabla;

        }
    } 
}
