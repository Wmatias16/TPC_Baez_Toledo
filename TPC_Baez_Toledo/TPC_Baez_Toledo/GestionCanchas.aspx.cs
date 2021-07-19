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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<Cancha> Lista = new List<Cancha>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] != null && ((Usuario)Session["Usuario"]).Rol.Nombre == "Administrador")
            {
                CanchaNegocio canchas = new CanchaNegocio();

                Lista = canchas.Listar();

                if (!IsPostBack)
                {
                    Repetidor.DataSource = Lista;
                    Repetidor.DataBind();
                }
            }
            else
            {
                Response.Redirect("Error.aspx");
            }          

        }


        protected void BtnEliminar(object sender, EventArgs e)
        {
            var argument = ((LinkButton)sender).CommandArgument;
            CanchaNegocio cancha = new CanchaNegocio();

            cancha.Eliminar(int.Parse(argument));

            Lista = cancha.Listar();
            Repetidor.DataSource = null;
            Repetidor.DataSource = Lista;
            Repetidor.DataBind();

        }


    }
}