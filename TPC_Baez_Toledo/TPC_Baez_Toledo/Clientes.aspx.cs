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
    public partial class Clientes : System.Web.UI.Page
    {
        public List<Usuario> clientes = new List<Usuario>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"]!=null &&((Usuario)Session["Usuario"]).Rol.Nombre == "Administrador")
            {
                UsuarioNegocio userNegocio = new UsuarioNegocio();

                clientes = userNegocio.Listar();
            }
            else
            {
                Response.Redirect("Error.aspx");
            }           
        }
    }
}