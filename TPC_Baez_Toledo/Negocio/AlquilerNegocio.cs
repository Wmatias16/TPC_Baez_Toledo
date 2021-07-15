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
                datos.Comando.Parameters.AddWithValue("@Estado", 1);

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
        public List<Alquiler> Listar()
        {
            List<Alquiler> listAlquiler = new List<Alquiler>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Query = "SELECT * FROM ALQUILERES";
                datos.SetearConsulta(Query);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Alquiler alqui = new Alquiler();


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
    }
}
