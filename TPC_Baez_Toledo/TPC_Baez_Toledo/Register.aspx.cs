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

		public string error;
		
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		private string encriptarSHA1(string vsValue)
		{
			System.Security.Cryptography.HashAlgorithm hashValue = new System.Security.Cryptography.SHA1CryptoServiceProvider();

			// Convert the original string to array of Bytes
			byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(vsValue);

			// Compute the Hash, returns an array of Bytes
			byte[] byteHash = hashValue.ComputeHash(byteValue);

			hashValue.Clear();

			// Return a base 64 encoded string of the Hash value
			return (Convert.ToBase64String(byteHash));
		}

		protected void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{

				if (Page.IsValid)
				{
					UsuarioNegocio UsuarioNeg = new UsuarioNegocio();

					if (!UsuarioNeg.Existe(txtEmail.Text))
					{
						if (txtPassword.Text == TxtConfirmarContra.Text)
						{
							Usuario NewUsuario = new Usuario();

							NewUsuario.Email = txtEmail.Text;
							NewUsuario.Contraseña = encriptarSHA1(txtPassword.Text);
							NewUsuario.Nombre = txtNombre.Text;
							NewUsuario.Apellidos = txtApellido.Text;
							NewUsuario.Telefono = txtTelefono.Text;
							NewUsuario.Rol = new Rol(2);

							UsuarioNeg.Agregar(NewUsuario);
							Session["Error"] = null;
							Response.Redirect("Login.aspx");
						}
						else
						{
							Session.Add("Error", "Las contraseñas no son iguales");
							error = (string)Session["Error"];
						}
					}
					else
					{
						Session.Add("Error", "Este mail ya existe");
						error = (string)Session["Error"];
					}
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