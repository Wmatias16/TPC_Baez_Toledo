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
        public DateTime fechaSeleccionada;
        string horarioSeleccionado;

        protected void Page_Load(object sender, EventArgs e)
        {
            horarioSeleccionado = listHorarios.SelectedValue;

            List<Cancha> canchas = new List<Cancha>();
            CanchaNegocio canchaNeg = new CanchaNegocio();
        
            AlquilerNegocio alquiNeg = new AlquilerNegocio();
            int ultimoDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            int DiaHoy = DateTime.Today.Day;
            int horaHoy = DateTime.Now.Hour;

            if (!IsPostBack)
            {              
                listDias.Items.Clear();

                for (int i = DiaHoy; i <= ultimoDia; i++)
                {
                    string s = $"{i}/{DateTime.Today.Month}/{DateTime.Today.Year}";
                    listDias.Items.Add(i.ToString());
                }

               
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

            fechaSeleccionada = new DateTime(DateTime.Today.Year, DateTime.Today.Month, int.Parse(listDias.SelectedValue));


            if (int.Parse(listDias.SelectedValue) != DiaHoy)
            {
                listHorarios.Items.Clear();

                for (int i = 0; i <= 23; i++)
                {
                    listHorarios.Items.Add(new DateTime().AddHours(i).AddMinutes(00).ToString("HH:mm"));
                }


            }
            else
            {

                listHorarios.Items.Clear();

                for (int i = horaHoy + 1; i <= 23; i++)
                {
                    listHorarios.Items.Add(new DateTime().AddHours(0 + i).AddMinutes(00).ToString("HH:mm"));
                }
            }

            List<string> horaAlqui = alquiNeg.listaHorariosAlquilados(fechaSeleccionada.ToString("yyyy-MM-dd"), int.Parse(Request.QueryString["Id"]));

            foreach (string hora in horaAlqui)
            {
                ListItem itemToRemove = listHorarios.Items.FindByValue(hora);

                if (itemToRemove != null)
                {
                    listHorarios.Items.Remove(itemToRemove);
                }
            }
        }

        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            AlquilerNegocio alquiNegocio = new AlquilerNegocio();
            CanchaNegocio NegCancha = new CanchaNegocio();            
            string diaSeleccionado = listDias.SelectedValue;

            Alquiler alquilar = new Alquiler();
            alquilar.Usuario = (Usuario)Session["Usuario"];
            alquilar.Cancha = NegCancha.BuscarCancha(idCancha);           
            alquilar.Horas = 1;
            alquilar.HoraAlquilada = horarioSeleccionado;
            alquilar.Fecha =  fechaSeleccionada;
            alquilar.Costo = alquilar.Cancha.Precio * alquilar.Horas;
            

            alquiNegocio.Agregar(alquilar);

        }

        protected void listDias_TextChanged(object sender, EventArgs e)
        {
            
            
        }

    }
}