using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public void Agregar(Usuario usuario)
        {
            AccesoDatos db = new AccesoDatos();

            try
            {
                string value = "values('" + usuario.Rol + "', '" + usuario.Nombre + "', '" + usuario.Apellidos + "', '" + usuario.Email + "', '" + usuario.Telefono + "')";
                db.SetearConsulta("INSERT INTO Usuarios(Rol,Nombre,Apellido,Email,Telefono)"+ value);

                db.EjectutarAccion();

            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                db.CerraConexion();
            }
        }
    }
}
