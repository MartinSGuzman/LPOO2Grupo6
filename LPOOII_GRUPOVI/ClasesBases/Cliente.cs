using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    public class Cliente
    {
        private int ClienteDNI;

        public int clienteDNI
        {
            get { return ClienteDNI; }
            set { ClienteDNI = value; }
        }
        private string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Telefono;

        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
    }
}
