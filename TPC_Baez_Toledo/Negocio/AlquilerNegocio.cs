using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class AlquilerNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public void Agregar(Alquiler NewAlquiler)
        {
            try
            {
                string values = "VALUES(@LegajoUsuario,@IdCancha,@Precio,@Horas,@HoraAlquilada,@Fecha,@Estado)";
                string query = "INSERT INTO Alquileres (LegajoUsuario,IdCancha,Precio,Horas,HoraAlquilada,Fecha,Estado)" + values;
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@LegajoUsuario", NewAlquiler.Usuario.Legajo);
                datos.Comando.Parameters.AddWithValue("@IdCancha", NewAlquiler.Cancha.Id);
                datos.Comando.Parameters.AddWithValue("@Precio", NewAlquiler.Costo);
                datos.Comando.Parameters.AddWithValue("@Horas", NewAlquiler.Horas);
                datos.Comando.Parameters.AddWithValue("@HoraAlquilada", NewAlquiler.HoraAlquilada);
                datos.Comando.Parameters.AddWithValue("@Fecha", NewAlquiler.Fecha.ToString("yyyy-MM-dd"));
                datos.Comando.Parameters.AddWithValue("@Estado", NewAlquiler.Estado.Id);

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
       

        public void Eliminar(Alquiler AlquilerDelete)
        {
            try
            {
                string query = "UPDATE Alquiler SET Estado = 0 WHERE ID " + AlquilerDelete.Id;
                datos.SetearConsulta(query);
                datos.EjectutarAccion();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                datos.EjectutarAccion();
            }

        }

        public List<Alquiler> ListarProxTurno(string fecha)
        {
            List<Alquiler> listAlquiler = new List<Alquiler>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Query = " select a.LegajoUsuario,u.Nombre,u.Apellido,c.Nombre as Ncancha,a.Precio,a.Horas,a.HoraAlquilada,a.Fecha,e.NOMBRE as Estado from Alquileres as a  Join Canchas as c on c.Id = a.IdCancha  Join Usuarios as u on u.Legajo = a.LegajoUsuario join EstadoAlquileres as e on e.id = a.Estado  where Fecha = '" + fecha + "' and a.Estado in (1,5,3) order by HoraAlquilada asc ";

                datos.SetearConsulta(Query);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Alquiler alqui = new Alquiler();
                    alqui.Usuario = new Usuario((int)datos.Leer["LegajoUsuario"]);
                    alqui.Usuario.Nombre = (string)datos.Leer["Nombre"];
                    alqui.Usuario.Apellidos = (string)datos.Leer["Apellido"];
                    alqui.Cancha = new Cancha((string)datos.Leer["Ncancha"]);
                    alqui.Costo = (decimal)datos.Leer["Precio"];
                    alqui.Horas = (Int16)datos.Leer["Horas"];
                    alqui.HoraAlquilada = (string)datos.Leer["HoraAlquilada"];
                    alqui.Fecha = (DateTime)datos.Leer["Fecha"];
                    alqui.Estado = new EstadoAlquiler((string)datos.Leer["Estado"]);

                    listAlquiler.Add(alqui);

                }
                return listAlquiler;
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
        public List<Alquiler> ListarPendientes()
        {
            List<Alquiler> listAlquiler = new List<Alquiler>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Query = " select a.Id as IDAlquiler, a.LegajoUsuario,u.Nombre,u.Apellido,c.Nombre as Ncancha,a.Precio,a.Horas,a.HoraAlquilada,a.Fecha,e.NOMBRE as Estado from Alquileres as a  Join Canchas as c on c.Id = a.IdCancha  Join Usuarios as u on u.Legajo = a.LegajoUsuario join EstadoAlquileres as e on e.id = a.Estado  where a.Estado = 3  order by HoraAlquilada asc ";

                datos.SetearConsulta(Query);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Alquiler alqui = new Alquiler();
                    alqui.Id = (int)datos.Leer["IDAlquiler"];
                    alqui.Usuario = new Usuario((int)datos.Leer["LegajoUsuario"]);
                    alqui.Usuario.Nombre = (string)datos.Leer["Nombre"];
                    alqui.Usuario.Apellidos = (string)datos.Leer["Apellido"];
                    alqui.Cancha = new Cancha((string)datos.Leer["Ncancha"]);
                    alqui.Costo = (decimal)datos.Leer["Precio"];
                    alqui.Horas = (Int16)datos.Leer["Horas"];
                    alqui.HoraAlquilada = (string)datos.Leer["HoraAlquilada"];
                    alqui.Fecha = (DateTime)datos.Leer["Fecha"];
                    alqui.Estado = new EstadoAlquiler((string)datos.Leer["Estado"]);

                    listAlquiler.Add(alqui);

                }
                return listAlquiler;
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




        public List<Alquiler> ListarPorUsuario(int Legajo)
        {
            List<Alquiler> listAlquiler = new List<Alquiler>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Query = "select a.LegajoUsuario,c.Nombre as Ncancha,a.Precio,a.Horas,a.HoraAlquilada,a.Fecha from Alquileres as a  Join Canchas as c on c.Id = a.IdCancha where a.LegajoUsuario = @Legajo order by Fecha desc";
                datos.Comando.Parameters.AddWithValue("@Legajo",Legajo);
                datos.SetearConsulta(Query);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Alquiler alqui = new Alquiler();
                   
                    alqui.Cancha = new Cancha((string)datos.Leer["Ncancha"]);
                    alqui.Costo = (decimal)datos.Leer["Precio"];
                    alqui.Horas = (Int16)datos.Leer["Horas"];
                    alqui.HoraAlquilada = (string)datos.Leer["HoraAlquilada"];
                    alqui.Fecha = (DateTime)datos.Leer["Fecha"];


                    listAlquiler.Add(alqui);

                }
                return listAlquiler;
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

        public List<string> listaHorariosAlquilados(string fecha,int idCancha)
        {
            List<string> horariosAlqui = new List<string>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Query = "select HoraAlquilada as Hora from Alquileres WHERE IdCancha=@idCancha AND Fecha=@Fecha AND Estado in (1,5,3)";

                datos.Comando.Parameters.AddWithValue("@idCancha",idCancha);
                datos.Comando.Parameters.AddWithValue("@Fecha", fecha);

                datos.SetearConsulta(Query);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    horariosAlqui.Add((string)datos.Leer["Hora"]);
                }
                return horariosAlqui;
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



        public void CambiarEstado(int idAlquiler,int idEstado)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                string query = "UPDATE Alquileres SET Estado = @IdEstado WHERE Id = @idAlquiler";
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@IdEstado", idEstado);
                datos.Comando.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                
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
