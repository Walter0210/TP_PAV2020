using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class OrdenPago
    {
        private int nroOC;
        private DateTime fecha;
        private int legajo;
        private int cuitSolicitante;

        public OrdenPago(int nroOC, DateTime fecha, int legajo, int cuitSolicitante)
        {
            NroOC = nroOC;
            Fecha = fecha;
            Legajo = legajo;
            CuitSolicitante = cuitSolicitante;
        }

        public int NroOC
        {
            get => nroOC;
            set => nroOC = value;
        }
        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }
        public int Legajo
        {
            get => legajo;
            set => legajo = value;
        }
        public int CuitSolicitante
        {
            get => cuitSolicitante;
            set => cuitSolicitante = value;
        }
    }
}
