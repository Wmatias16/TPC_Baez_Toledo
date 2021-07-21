using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class EstadoAlquiler
    {
        ///Propediades
        private int id;
        private string nombre;
        ///Metodos

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public EstadoAlquiler(string nombre)
        {
            this.Nombre = nombre;
        }

        public EstadoAlquiler(int id)
        {
            this.id = id;
        }


        public override string ToString()
        {
            return this.nombre;
        }

    }
}
