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
    public partial class About : Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cancha> ListCancha = new List<Cancha>();
            CanchaNegocio Canchanegocio = new CanchaNegocio();
            ListCancha = Canchanegocio.Listar();
            Dgv.DataSource = ListCancha;
            Dgv.DataBind();
        }

        protected void Prueba_Click(object sender, EventArgs e)
        {
            
        }

    }
}