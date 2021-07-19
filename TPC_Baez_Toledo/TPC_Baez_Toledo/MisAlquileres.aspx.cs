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
    public partial class WebForm4 : System.Web.UI.Page
    {
        public List<Alquiler> alquileres = new List<Alquiler>();
        AlquilerNegocio NegAlquiler = new AlquilerNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Legajo = ((Usuario)Session["Usuario"]).Legajo;    
            alquileres = NegAlquiler.ListarPorUsuario(Legajo);

        }
    }
}