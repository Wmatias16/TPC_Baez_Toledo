using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Baez_Toledo
{
    public partial class Canchas : System.Web.UI.Page
    {

        public List<Cancha> canchas = new List<Cancha>();
        public CanchaNegocio canchaNegocio = new CanchaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                canchas = canchaNegocio.Listar();
                Session.Add("ListarCanchas", canchas);

            }
            catch(Exception err)
            {
                Session.Add("Error", err.ToString());
                ///Redireccionar a pagina error
            }



        }
    }
}