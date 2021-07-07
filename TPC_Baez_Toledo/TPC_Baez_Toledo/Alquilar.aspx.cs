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

    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<int> dias = new List<int>();
        public Cancha cancha = new Cancha();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cancha> canchas = new List<Cancha>();
            CanchaNegocio canchaNeg = new CanchaNegocio();

            int id = int.Parse(Request.QueryString["Id"]);

            canchas = canchaNeg.Listar();

            cancha = canchas.Find(x => x.Id == id);

            if (cancha == null)
            {
                Session.Add("Error", "Producto inexistente");
               // Response.Redirect("Error.aspx");
            }

            int ultimoDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            int DiaHoy = DateTime.Today.Day;


            for (int i = DiaHoy; i <= ultimoDia; i++)
            {
                dias.Add(i);
            }
        }
    }
}