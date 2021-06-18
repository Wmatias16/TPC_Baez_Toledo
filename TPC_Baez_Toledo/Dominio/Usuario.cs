using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private int legajo;
        private int rol; 
        private string nombre;
        private string apellidos;
        private string email;
        private string telefono;

        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public int Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

    }

}
