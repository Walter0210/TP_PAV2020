using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Clases
{
    class Estacion
    {
        private int cuit;
        private string razonSocial;
        private string calle;
        private int nro;
        private DateTime fechaHabilitacion;

        public Estacion(int cuit, string razonSocial, string calle, int nro, DateTime fechaHabilitaicon)
        {
            Cuit = cuit;
            RazonSocial = razonSocial;
            Calle = calle;
            Nro = nro;
            FechaHabilitacion = fechaHabilitacion;
        }

        public int Cuit
        {
            get => cuit;
            set => cuit = value;
        }
        public string RazonSocial
        {
            get => razonSocial;
            set => razonSocial = value;
        }
        public string Calle
        {
            get => calle;
            set => calle = value;
        }
        public int Nro
        {
            get => nro;
            set => nro = value;
        }
        public DateTime FechaHabilitacion
        {
            get => fechaHabilitacion;
            set => fechaHabilitacion = value;
        }
    }
}
