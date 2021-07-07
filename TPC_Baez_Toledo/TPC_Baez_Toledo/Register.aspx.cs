using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Baez_Toledo
{
	public partial class Register : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				UsuarioNegocio UsuarioNeg = new UsuarioNegocio();
				Usuario NewUsuario = new Usuario();
				
				NewUsuario.Email = txtEmail.Text;
				NewUsuario.Contraseña = txtPassword.Text;
				NewUsuario.Nombre = txtNombre.Text;
				NewUsuario.Apellidos = txtApellido.Text;
				NewUsuario.Telefono = txtTelefono.Text;
				NewUsuario.Rol.Id = 1; // asignamos id 1 cliente

				if (txtPassword.Text == TxtConfirmarContra.Text && !UsuarioNeg.Existe(NewUsuario.Email))//Confirmamos contraseña y validamos email
				{
					UsuarioNeg.Agregar(NewUsuario);//Lo agregamos a la base de datos
				}
				else
				{
					//No se puede agregar por validaciones		
				}

			}
			catch (Exception err)
			{
				throw err;
			}
			finally
			{

			}

		}

	}
}