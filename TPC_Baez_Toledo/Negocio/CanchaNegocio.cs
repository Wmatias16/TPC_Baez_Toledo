using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{   
   
    public class CanchaNegocio
    {
        AccesoDatos datos;
        
        public void Agregar(Cancha newCancha)
        {        
 
            try
            {
                datos = new AccesoDatos();
                string query = "INSERT INTO Canchas VALUES(@Nombre,@Precio,@IdTipoCancha,@Descripcion,@UrlImagen)";
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@Nombre", newCancha.Nombre);
                datos.Comando.Parameters.AddWithValue("@Precio", newCancha.Precio);
                datos.Comando.Parameters.AddWithValue("@IdTipoCancha", newCancha.TipoCancha);
                datos.Comando.Parameters.AddWithValue("@Descripcion", newCancha.Descripcion);
                datos.Comando.Parameters.AddWithValue("@UrlImagen", newCancha.UrlImagen);
                datos.EjectutarAccion();
             

            }
            catch(Exception err)
            {
                throw err;
            }
            finally
            {
                datos.CerraConexion();
            }


        }

        public List<Cancha> Listar()
        {
            List<Cancha> Listcancha = new List<Cancha>();
            datos = new AccesoDatos();
            try
            {         
                datos.SetearConsulta("Select C.Id,C.Nombre,C.Precio,C.Descripcion,C.UrlImagen,T.Id,T.Nombre From Canchas AS C, TipoCanchas AS T WHERE T.Id = C.IdTipoCancha");
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Cancha newCancha = new Cancha();


                    newCancha.Id = (Int16)datos.Leer["Id"];
                    newCancha.Nombre = (string)datos.Leer["Nombre"];
                    newCancha.Precio = (decimal)datos.Leer["Precio"];
                    newCancha.Descripcion = (string)datos.Leer["Descripcion"];
                    newCancha.UrlImagen = (string)datos.Leer["UrlImagen"];
                    newCancha.TipoCancha = new TipoCancha((string)datos.Leer["Nombre"]);

                    Listcancha.Add(newCancha);

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
    }
}
