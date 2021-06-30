using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Alquiler
    {
        //Propiedades
        private int id;
        private Usuario usuario;
        private Cancha cancha;
        private decimal costo;
        private int horas;
        private string fecha;

        //getts y setts
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Usuario Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        public Cancha Cancha
        {
            get { return Cancha; }
            set { Cancha = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        public string  Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


    }
}
