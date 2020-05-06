using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class Estado
    {
        private int idEstado;
        private string nombre;

        public Estado(int idEstado, string nombre)
        {
            IdEstado = idEstado;
            Nombre = nombre;
        }

        public int IdEstado
        {
            get => idEstado;
            set => idEstado = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
