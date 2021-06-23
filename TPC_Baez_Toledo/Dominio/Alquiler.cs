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
        private int legajoUsuario;
        private int idCancha;
        private decimal costo;
        private int horas;
        private string fecha;

        //getts y setts
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int LegajoUsuario
        {
            get { return legajoUsuario; }
            set { legajoUsuario = value; }
        }

        public int IdCancha
        {
            get { return idCancha; }
            set { idCancha = value; }
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
