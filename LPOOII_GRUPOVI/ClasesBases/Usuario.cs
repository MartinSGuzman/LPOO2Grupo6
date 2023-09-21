using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    public class Usuario
    {
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Password;

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        private string UserName;

        public string username
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private string Rol;

        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }
    }
}
