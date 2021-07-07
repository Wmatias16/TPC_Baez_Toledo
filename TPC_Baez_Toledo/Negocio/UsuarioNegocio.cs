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
        AccesoDatos datos;

        public void Agregar(Usuario nuevoUsuario)
        {
            try
            {
                datos = new AccesoDatos();
                string query = "INSERT INTO Usuarios VALUES(@Rol,@Nombre,@Apellidos,@Email,@Contraseña,@Telefono)";
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@Rol", nuevoUsuario.Rol.Id);
                datos.Comando.Parameters.AddWithValue("@Nombre", nuevoUsuario.Nombre);
                datos.Comando.Parameters.AddWithValue("@Apellidos", nuevoUsuario.Apellidos);
                datos.Comando.Parameters.AddWithValue("@Email", nuevoUsuario.Email);
                datos.Comando.Parameters.AddWithValue("@Contraseña", nuevoUsuario.Contraseña);
                datos.Comando.Parameters.AddWithValue("@Telefono", nuevoUsuario.Telefono);

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
        public bool Existe(string email)//buscamos email en la base de datos
        {
            datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT COUNT(*) as Cant FROM Usuarios WHERE Email=@Email");
                datos.Comando.Parameters.AddWithValue("@Email", email);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    if ((int)datos.Leer["Cant"] == 1)
                    {
                        return true;
                    }
                }

                return false;
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
        public Usuario Validar(string email, string contraseña)
        {
            try
            {
                datos.SetearConsulta("SELECT U.Legajo,R.Nombre AS Rol,U.Nombre,U.Apellido,U.Email,U.Telefono FROM Usuarios AS U, Roles AS R WHERE R.ID = U.ROL AND Email=@Email and Contraseña=@Contraseña");

                //datos.Comando.Parameters.AddWithValue("@Email", email);
                datos.Comando.Parameters.AddWithValue("@Contraseña", contraseña);

                datos.EjecutarLectura();
                Usuario us = new Usuario();

                while (datos.Leer.Read())
                {
                    us.Legajo = (int)datos.Leer["Legajo"];
                    us.Rol = new Rol((string)datos.Leer["Rol"]);
                    us.Nombre = (string)datos.Leer["Nombre"];
                    us.Apellidos = (string)datos.Leer["Apellido"];
                    us.Email = (string)datos.Leer["Email"];
                    us.Telefono = (string)datos.Leer["Telefono"];
                }
                return us;
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



        public List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string Query = "SELECT U.Legajo,R.Nombre AS Rol, U.Nombre,U.Apellido,U.Email,U.Telefono FROM Usuarios AS U, Roles AS R WHERE  R.ID = U.ROL AND U.Estado = 1";
                datos.SetearConsulta(Query);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Usuario us = new Usuario();

                    us.Legajo = (int)datos.Leer["Legajo"];
                    us.Rol = new Rol((string)datos.Leer["Rol"]);
                    us.Nombre = (string)datos.Leer["Nombre"];
                    us.Apellidos = (string)datos.Leer["Apellido"];
                    us.Email = (string)datos.Leer["Email"];
                    us.Telefono = (string)datos.Leer["Telefono"];

                    usuarios.Add(us);
                }
                return usuarios;
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

        public void Editar(Usuario nuevoUsuario)
        {
            try
            {
                datos = new AccesoDatos();
                string query = "UPDATE Usuarios SET Rol=@Rol,Nombre=@Nombre,Apellido=@Apellidos,Email=@Email,Telefono=@Telefono WHERE Legajo=" + nuevoUsuario.Legajo;
                datos.SetearConsulta(query);

                datos.Comando.Parameters.AddWithValue("@Rol", nuevoUsuario.Rol.Id);
                datos.Comando.Parameters.AddWithValue("@Nombre", nuevoUsuario.Nombre);
                datos.Comando.Parameters.AddWithValue("@Apellidos", nuevoUsuario.Apellidos);
                datos.Comando.Parameters.AddWithValue("@Email", nuevoUsuario.Email);
                datos.Comando.Parameters.AddWithValue("@Telefono", nuevoUsuario.Telefono);

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


        public void Eliminar(int legajo)
        {
            try
            {
                datos = new AccesoDatos();
                string query = "UPDATE Usuarios SET ESTADO = 0 WHERE LEGAJO=" + legajo;
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
