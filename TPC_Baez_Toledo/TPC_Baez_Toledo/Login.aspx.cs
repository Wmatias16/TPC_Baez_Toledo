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
        public bool error = false;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Validar(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            
            if (negocio.Existe(txtEmail.Text) == true)
            {

                Usuario user = negocio.Validar(txtEmail.Text, txtPassword.Text);

                if (user != null)
                {
                    Session.Add("Usuario", user);
                    Response.Redirect("Canchas.aspx");
                }
                else
                {
                    Session["ERROR"] = "Contraseña incorrecta";
                }

            }
            else
            {
                Session.Add("Error", "No existe este mail");
            }
        }
    }
}