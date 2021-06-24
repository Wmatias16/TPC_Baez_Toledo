using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cancha
    {
        //propiedades
        private int id;
        private string nombre;    
        private decimal precio;
        private TipoCancha tipoCancha;
        private string descripcion;
        private string urlImagen;
        //metodos

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public TipoCancha TipoCancha
        {
            get { return tipoCancha; }
            set { tipoCancha = value; }
        }
          

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string UrlImagen
        {
            get { return urlImagen; }
            set { urlImagen = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


    }
}

