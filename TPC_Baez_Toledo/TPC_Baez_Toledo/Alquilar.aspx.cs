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
        public Cancha cancha = new Cancha();
        public int idCancha;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cancha> canchas = new List<Cancha>();
            CanchaNegocio canchaNeg = new CanchaNegocio();

            if (!IsPostBack)
            {


            }

            idCancha = int.Parse(Request.QueryString["Id"]);
            canchas = canchaNeg.Listar();

            if (cancha == null)
            {
                Session.Add("Error", "Producto inexistente");
                // Response.Redirect("Error.aspx");
            }

            cancha = canchas.Find(x => x.Id == idCancha);

            List<DateTime> hours = new List<DateTime>();
            List<int> dias = new List<int>();

            int ultimoDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            int DiaHoy = DateTime.Today.Day;
            int horaHoy = DateTime.Now.Hour;
            






            for (int i = DiaHoy; i <= ultimoDia; i++)
            {
                string s = $"{i}/{DateTime.Today.Month}/{DateTime.Today.Year}";
                listDias.Items.Add(i.ToString());
            }
            if(int.Parse(listDias.SelectedValue)!= DiaHoy)
            {
                for (int i = 0 ; i <= 23; i++)
                {
                    listHorarios.Items.Add(new DateTime().AddHours(i).AddMinutes(00).ToString("HH:mm"));
                }
            }
            else {
                for (int i = horaHoy + 1; i <= 23; i++)
                {
                    listHorarios.Items.Add(new DateTime().AddHours(0 + i).AddMinutes(00).ToString("HH:mm"));
                }
            }
            


        }

        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            AlquilerNegocio alquiNegocio = new AlquilerNegocio();
            CanchaNegocio NegCancha = new CanchaNegocio();
            string horarioSeleccionado = listHorarios.SelectedValue;
            string diaSeleccionado = listDias.SelectedValue;



            Alquiler alquilar = new Alquiler();
            alquilar.Usuario = (Usuario)Session["Usuario"];
            alquilar.Cancha = NegCancha.BuscarCancha(idCancha);           
            alquilar.Horas = 1;
            alquilar.HoraAlquilada = horarioSeleccionado;
            alquilar.Fecha =  DateTime.Now;
            alquilar.Costo = 500;
            

            alquiNegocio.Agregar(alquilar);

        }
    }
}