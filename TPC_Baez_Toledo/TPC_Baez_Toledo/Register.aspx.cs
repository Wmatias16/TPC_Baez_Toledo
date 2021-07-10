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

                if (!UsuarioNeg.Existe(txtEmail.Text))
                {
					if (txtPassword.Text == TxtConfirmarContra.Text)
					{
						Usuario NewUsuario = new Usuario();

						NewUsuario.Email = txtEmail.Text;
						NewUsuario.Contraseña = txtPassword.Text;
						NewUsuario.Nombre = txtNombre.Text;
						NewUsuario.Apellidos = txtApellido.Text;
						NewUsuario.Telefono = txtTelefono.Text;
						NewUsuario.Rol = new Rol(2);

						UsuarioNeg.Agregar(NewUsuario);
						Response.Redirect("Login.aspx");
                    }
                    else
                    {
						Session.Add("Error", "Las contraseñas no son iguales");
					}
				}				
				else
				{
					Session.Add("Error", "Este mail ya existe");	
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