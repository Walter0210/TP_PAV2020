using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class Ticket
    {
        private int nroTicket;
        private DateTime fecha;
        private int cuit;
        private int nroSurtidor;
        private int cantidad;
        private int idUnidadMedida;
        private string observacion;

        public Ticket(int nroTicket, DateTime fecha, int cuit, int nroSurtidor, int cantidad, int idUnidadMedida, string observacion)
        {
            NroTicket = nroTicket;
            Fecha = fecha;
            Cuit = cuit;
            NroSurtidor = nroSurtidor;
            Cantidad = cantidad;
            IdUnidadMedida = idUnidadMedida;
            Observacion = observacion;

        }

        public Ticket()
        {
          

        }

        public int NroTicket
        {
            get => nroTicket;
            set => nroTicket = value;
        }

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        public int Cuit
        {
            get => cuit;
            set => cuit = value;
        }

        public int NroSurtidor
        {
            get => nroSurtidor;
            set => nroSurtidor = value;
        }
        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public int IdUnidadMedida
        {
            get => idUnidadMedida;
            set => idUnidadMedida = value;
        }

        public string Observacion
        {
            get => observacion;
            set => observacion = value;
        }
    }
}
