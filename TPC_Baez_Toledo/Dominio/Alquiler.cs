using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Alquiler
    {
        //Propiedades
        private int id;
        private Usuario usuario;
        private Cancha cancha;
        private decimal costo;
        private int horas;
        private string horaAlquilada;
        private DateTime fecha;
        private EstadoAlquiler estado;

        //getts y setts
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Cancha Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }

        public EstadoAlquiler Estado
        {
            get { return estado; }
            set { estado = value; }
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

        public string HoraAlquilada
        {
            get { return horaAlquilada; }
            set { horaAlquilada = value; }
        }

        public DateTime  Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


    }
}
