using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    class AlquilerNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public void Agregar(Alquiler NewAlquiler)
        {
            try
            {   
                string query = "INSERT INTO Alquileres VALUES(@LegajoUsuario,@IdCancha,@Precio,@Horas,@Fecha,@Estado)";
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@LegajoUsuario", NewAlquiler.Usuario.Legajo);
                datos.Comando.Parameters.AddWithValue("@IdCancha", NewAlquiler.Cancha.Id);
                datos.Comando.Parameters.AddWithValue("@Precio", NewAlquiler.Costo);
                datos.Comando.Parameters.AddWithValue("@Horas", NewAlquiler.Horas);
                datos.Comando.Parameters.AddWithValue("@Fecha", NewAlquiler.Fecha);///--------------Vefificar esto 
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

        public void Eliminar(Alquiler AlquilerDelete)
        {
            try
            {
                string query = "UPDATE Alquiler SET Estado = 0 WHERE ID " + AlquilerDelete.Id;
                datos.SetearConsulta(query);
                datos.EjectutarAccion();

            }
            catch(Exception err)
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
