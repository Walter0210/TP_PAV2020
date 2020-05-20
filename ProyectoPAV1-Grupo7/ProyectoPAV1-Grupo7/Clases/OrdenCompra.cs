using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class OrdenCompra
    {
        private int nroOC;
        private DateTime fecha;
        private int legajo;
        private int cuitSolicitante;
        private float total;

        public OrdenCompra(int nroOC, DateTime fecha, int legajo, int cuitSolicitante, float total)
        {
            NroOC = nroOC;
            Fecha = fecha;
            Legajo = legajo;
            CuitSolicitante = cuitSolicitante;
            Total = total;
        }

        public OrdenCompra()
        {

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

        public float Total
        {
            get => total;
            set => total = value;
        }
    }
}
