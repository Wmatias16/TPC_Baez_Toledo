using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Dominio;
namespace TPC_Baez_Toledo
{
    public partial class SiteMaster : MasterPage
    {

        public Usuario user;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            user = (Usuario)Session["Usuario"];
        }

        protected void CerrarSesion(object sender, EventArgs e)
        {
            Session["Usuario"] = null;

            Response.Redirect("Login.aspx");
        }


    }
}