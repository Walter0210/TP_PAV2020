﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV1_Grupo7.Clases
{
    public class Surtidor
    {
        private int nroSurtidor;
        private int cuit;
        private int idEstado;
        private int idTipoComb;

        //le saco el tributo nroSurtidor porque no me deja insertar
        public Surtidor(int cuit, int idEstado, int idTipoComb)
        {
            NroSurtidor = nroSurtidor;
            CUIT = cuit;
            IdEstado = idEstado;
            IdTipoComb = idTipoComb;
        }

        public Surtidor ()
        {

        }

        public int NroSurtidor
        {
            get => nroSurtidor;
            set => nroSurtidor = value;
        }
        public int CUIT
        {
            get => cuit;
            set => cuit = value;
        }
        public int IdEstado
        {
            get => idEstado;
            set => idEstado = value;
        }
        public int IdTipoComb
        {
            get => idTipoComb;
            set => idTipoComb = value;
        }
    }
}
