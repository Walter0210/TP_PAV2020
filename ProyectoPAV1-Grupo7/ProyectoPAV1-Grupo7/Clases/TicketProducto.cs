using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class TicketProducto
    {
        private int nroTicket;
        private int idProducto;
        private string cantidad;
        private float precio;

        public TicketProducto(int nroTicket, int idProducto, string cantidad, float precio)
        {
            NroTicket = nroTicket;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Precio = precio;
        }

        public int NroTicket
        {
            get => nroTicket;
            set => nroTicket = value;
        }
        public int IdProducto
        {
            get => idProducto;
            set => idProducto = value;
        }

        public string Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public float Precio
        {
            get => precio;
            set => precio = value;
        }
    }
}
