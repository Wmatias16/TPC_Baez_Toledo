using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class TipoCanchaNegocio
    {
        AccesoDatos datos;


        public List<TipoCancha> ListarTipoCancha()
        {
            List<TipoCancha> Listcancha = new List<TipoCancha>();
            datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select c.Id,c.Nombre from TipoCanchas as c");
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    TipoCancha Tipos = new TipoCancha((Int16)datos.Leer["Id"]);

                    Tipos.Nombre = (string)datos.Leer["Nombre"];

                    Listcancha.Add(Tipos);

                }

                return Listcancha;

            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                datos.CerraConexion();
            }

        }


        public TipoCancha BuscarTipoCancha(string Nombre)
        {
            AccesoDatos datos = new AccesoDatos();
            TipoCancha Tipo = new TipoCancha(Nombre);
            try
            {
                datos.SetearConsulta("select c.Id,c.Nombre from TipoCanchas as c WHERE C.Nombre = '" + Nombre + "'");
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Tipo.Id = (Int16)datos.Leer["Id"];
                }



                return Tipo;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                datos.CerraConexion();
            }
        }

    }
}
