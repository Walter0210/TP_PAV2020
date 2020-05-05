using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    class Producto
    {
        private int codigo;
        private string descripcion;
        private int stockActual;
        private float precioCompra;
        private float precioVenta;
        private DateTime ultimaFechaActStock;

        public Producto(int codigo, string descripcion, int stockActual, float precioCompra, float precioVenta, DateTime ultimaFechaActStock)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            StockActual = stockActual;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            UltimaFechaActStock = ultimaFechaActStock

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
    }
}
