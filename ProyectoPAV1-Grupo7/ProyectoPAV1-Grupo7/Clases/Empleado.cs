using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class Empleado
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int tipoDoc;
        private int nroDoc;
        private DateTime fechaNacimiento;
        private DateTime fechaAlta;
        private int legajoSuperior;

        public Empleado(int legajo, string nombre, string apellido, int tipoDoc, int nroDoc, DateTime fechaNacimiento, DateTime fechaAlta, int legajoSuperior)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipoDoc;
            NroDoc = nroDoc;
            FechaNacimiento = fechaNacimiento;
            FechaAlta = fechaAlta;
            LegajoSuperior = legajoSuperior;
        }

        public Empleado(string nombre, string apellido, int tipoDoc, int nroDoc, DateTime fechaNacimiento, DateTime fechaAlta, int legajoSuperior)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipoDoc;
            NroDoc = nroDoc;
            FechaNacimiento = fechaNacimiento;
            FechaAlta = fechaAlta;
            LegajoSuperior = legajoSuperior;
        }


        public Empleado() { }

        public string Nombre 
        {   
            get => nombre; 
            set => nombre = value; 
        }
        public int Legajo 
        { 
            get => legajo; 
            set => legajo = value; 
        }
        public string Apellido 
        { 
            get => apellido; 
            set => apellido = value; 
        }
        public int TipoDoc 
        { 
            get => tipoDoc; 
            set => tipoDoc = value; 
        }
        public int NroDoc 
        { 
            get => nroDoc; 
            set => nroDoc = value; 
        }
        public DateTime FechaNacimiento 
        { 
            get => fechaNacimiento; 
            set => fechaNacimiento = value; 
        }
        public DateTime FechaAlta 
        { 
            get => fechaAlta; 
            set => fechaAlta = value; 
        }
        public int LegajoSuperior 
        { 
            get => legajoSuperior; 
            set => legajoSuperior = value; 
        }
    }
}
