﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    public class TipoVehiculo
    {
        private int TVCodigo;

        public int tVCodigo
        {
            get { return TVCodigo; }
            set { TVCodigo = value; }
        }
        private string Descripcion;

        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private decimal Tarifa;

        public decimal tarifa
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }
    }
}
