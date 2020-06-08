using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class Producto
    {
        private int codigo;
        private string descripcion;
        private int stockActual;
        private float precioCompra;
        private float precioVenta;
        private DateTime ultimaFechaActStock;

        public Producto(string descripcion, int stockActual, float precioCompra, float precioVenta, DateTime ultimaFechaActStock)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            StockActual = stockActual;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            UltimaFechaActStock = ultimaFechaActStock;
        }

        public Producto(int codigo)
        {
            Codigo = codigo;
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public int StockActual
        {
            get => stockActual;
            set => stockActual = value;
        }
        public float PrecioCompra
        {
            get => precioCompra;
            set => precioCompra = value;
        }

        public float PrecioVenta
        {
            get => precioVenta;
            set => precioVenta = value;
        }
        public DateTime UltimaFechaActStock
        {
            get => ultimaFechaActStock;
            set => ultimaFechaActStock = value;
        }

        public int consultarStockActualProducto(int idProducto, ConexionBD conexion)
        {
            string consulta = "SELECT stockActual FROM Producto WHERE idProducto = " + Codigo;
            DataTable stockActualProducto = conexion.ejecutar_consulta(consulta);
            int stockActual = int.Parse(stockActualProducto.Rows[0][0].ToString());
            return stockActual;
        }

        public void actualizarStockActualProducto(int CantidadSeleccionada)
        {
            ConexionBD conexion = new ConexionBD();
            int stockActual = consultarStockActualProducto(Codigo, conexion);
            int nuevaCantidad = stockActual + CantidadSeleccionada;
            string fechaActualizacion = DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "UPDATE Producto SET stockActual = " + nuevaCantidad + ", fechaUltimaActualizacion = '" + fechaActualizacion + "' WHERE idProducto = " + Codigo;
            conexion.ejecutar_consulta(sql);
        }
    }
}
