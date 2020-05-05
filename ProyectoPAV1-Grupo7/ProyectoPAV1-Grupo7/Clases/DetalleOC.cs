using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class DetalleOC
    {
        private int nroOC;
        private int idProducto;
        private int cantidad;
        private int unidadMedida;
        private float precio;
        private int idUrgencia;

        public DetalleOC(int nroOC, int idProducto, int cantidad, int unidadMedida, float precio, int idUrgencia)
        {
            NroOC = nroOC;
            IdProducto = idProducto;
            Cantidad = cantidad;
            UnidadMedida = unidadMedida;
            Precio = precio;
            IdUrgencia = idUrgencia;

        }

        public int NroOC
        {
            get => nroOC;
            set => nroOC = value;
        }

        public int IdProducto
        {
            get => idProducto;
            set => idProducto = value;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        
        public int UnidadMedida
        {
            get => unidadMedida;
            set => unidadMedida = value;
        }
        public float Precio
        {
            get => precio;
            set => precio = value;
        }
        public int IdUrgencia
        {
            get => idUrgencia;
            set => idUrgencia = value;
        }
    }
}
