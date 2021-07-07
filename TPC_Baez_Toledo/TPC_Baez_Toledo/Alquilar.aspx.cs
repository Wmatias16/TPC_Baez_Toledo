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
         int ultimoDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
         int DiaHoy = (int )DateTime.Today.Day;
        public List<int> dias = new List<int>();


        List<Cancha>canchas = new List<Cancha>();
        public Cancha cancha = new Cancha();
        CanchaNegocio canchaNeg = new CanchaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);

            canchas = canchaNeg.Listar();

            cancha = canchas.Find(x => x.Id == id);

            if (cancha == null)
            {
                Session.Add("Error", "Producto inexistente");
               // Response.Redirect("Error.aspx");
            }


           

            for(int i = DiaHoy; i <= ultimoDia; i++)
            {
                dias.Add(i);
            }



        }
    }
}