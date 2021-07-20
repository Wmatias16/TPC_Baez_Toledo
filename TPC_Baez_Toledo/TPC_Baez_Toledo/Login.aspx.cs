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
    public partial class Login : System.Web.UI.Page
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

        protected void Validar(object sender, EventArgs e)
        {

            UsuarioNegocio negocio = new UsuarioNegocio();
            
            if (negocio.Existe(txtEmail.Text) == true)
            {

                Usuario user = negocio.Validar(encriptarSHA1(txtPassword.Text));

                if (user.Email != null)
                {
                    Session.Add("Usuario", user);
                    Session["Error"] = null;

                    if(user.Rol.Nombre == "Administrador")
                    {
                        Response.Redirect("Page-admin.aspx");
                    }
                    else
                    {
                        Response.Redirect("Canchas.aspx");
                    }                    
                    
                }
                else
                {
                    Session["Error"] = "Contraseña incorrecta";
                    error = (string)Session["Error"];
                }

            }
            else
            {
                Session["Error"] = "No existe este mail";
                error = (string)Session["Error"];
            }
                      
        }

    }
}