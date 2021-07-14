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
                string values = "VALUES(@Nombre,@Precio,@IdTipoCancha,@Descripcion,@UrlImagen)";
                string query = "INSERT INTO Canchas(Nombre,Precio,IdTipoCancha,Descripcion,UrlImagen)" + values;
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@Nombre", newCancha.Nombre);
                datos.Comando.Parameters.AddWithValue("@Precio", newCancha.Precio);
                datos.Comando.Parameters.AddWithValue("@IdTipoCancha", newCancha.TipoCancha.Id);
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
                datos.SetearConsulta("Select C.Id,C.Nombre,C.Precio,C.Descripcion,C.UrlImagen,T.Id,T.Nombre From Canchas AS C, TipoCanchas AS T WHERE T.Id = C.IdTipoCancha and C.Estado = 1");
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
                datos.SetearConsulta("select c.Id,c.Nombre from TipoCanchas as c WHERE C.Nombre = '"+Nombre+"'");
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Tipo.Id = (Int16)datos.Leer["Id"];
                }

                

                return Tipo;
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

        public Cancha BuscarCancha(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Cancha NewCancha = new Cancha();
            try
            {
                datos.SetearConsulta("Select C.Id,C.Nombre,C.Precio,C.Descripcion,C.UrlImagen,T.Id,T.Nombre as Nombrex From Canchas AS C, TipoCanchas AS T WHERE T.Id = C.IdTipoCancha and C.Id = '" + id+"'");
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    NewCancha.Id = (Int16)datos.Leer["Id"];
                    NewCancha.Nombre = (string)datos.Leer["Nombre"];
                    NewCancha.Precio = (decimal)datos.Leer["Precio"];
                    NewCancha.Descripcion = (string)datos.Leer["Descripcion"];
                    NewCancha.UrlImagen = (string)datos.Leer["UrlImagen"];
                    NewCancha.TipoCancha = new TipoCancha((string)datos.Leer["Nombrex"]);
                }

                return NewCancha;
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


        public void Editar(Cancha CanchaEdit)
        {       
            try
            {   
                AccesoDatos datos = new AccesoDatos();
                string query = "UPDATE Canchas SET Nombre=@Nombre,Precio=@Precio,IdTipoCancha=@IdTipoCancha,Descripcion=@Descripcion,UrlImagen=@UrlImagen WHERE Id = " + CanchaEdit.Id;
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@Nombre",CanchaEdit.Nombre);
                datos.Comando.Parameters.AddWithValue("@Precio", CanchaEdit.Precio);
                datos.Comando.Parameters.AddWithValue("@IdTipoCancha", CanchaEdit.TipoCancha.Id);
                datos.Comando.Parameters.AddWithValue("@Descripcion", CanchaEdit.Descripcion);
                datos.Comando.Parameters.AddWithValue("@UrlImagen", CanchaEdit.UrlImagen);

                datos.EjectutarAccion();


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

        public void Eliminar(int IdCancha)
        {
            try
            {
                datos = new AccesoDatos();
                string query = "UPDATE Canchas SET Estado = 0 WHERE Id=" + IdCancha;
                datos.SetearConsulta(query);
                datos.EjectutarAccion();
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
