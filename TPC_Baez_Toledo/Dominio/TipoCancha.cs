using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoCancha
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

        public TipoCancha (string nombre)
        {
          this.Nombre = nombre;
        }


        public override string ToString()
        {
            return this.nombre;
        }


    }
}
