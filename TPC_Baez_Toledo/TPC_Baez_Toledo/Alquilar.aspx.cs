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
            List<Cancha> canchas = new List<Cancha>();
            CanchaNegocio canchaNeg = new CanchaNegocio();

            AlquilerNegocio alquiNeg = new AlquilerNegocio();

            int ultimoDia = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            int DiaHoy = DateTime.Today.Day;
            int horaHoy = DateTime.Now.Hour;

            if (!IsPostBack)
            {              
                for (int i = DiaHoy; i <= ultimoDia; i++)
                {
                    string s = $"{i}/{DateTime.Today.Month}/{DateTime.Today.Year}";
                    listDias.Items.Add(i.ToString() +"  "+ new DateTime(DateTime.Today.Year, DateTime.Today.Month,i).ToString("dddd"));
                }

                if (Request.QueryString["Id"] != null)
                {
                    idCancha = int.Parse(Request.QueryString["Id"]);
                    canchas = canchaNeg.Listar();

                    if (canchas != null)
                    {
                        Session["Cancha"] = canchas.Find(x => x.Id == idCancha);
                    }
                    else
                    {
                        Response.Redirect("Error.aspx");
                    }                    
                }


                listMetodoPago.Items.Add("Efectivo");
                listMetodoPago.Items.Add("Mercado Pago");
            }


            if (Session["Cancha"] != null)
            {
                idCancha = int.Parse(Request.QueryString["Id"]);
                cancha = (Cancha)Session["Cancha"];
            }



            List<DateTime> hours = new List<DateTime>();
            List<int> dias = new List<int>();

            horarioSeleccionado = listHorarios.SelectedValue;


            if (int.Parse(listDias.SelectedValue.Substring(0,2)) != DiaHoy)
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

            fechaSeleccionada = new DateTime(DateTime.Today.Year, DateTime.Today.Month, int.Parse(listDias.SelectedValue.Substring(0,2)));

            List<string> horasAlquiladas = alquiNeg.listaHorariosAlquilados(fechaSeleccionada.ToString("yyyy-MM-dd"),idCancha);

            foreach (string hora in horasAlquiladas)
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

            Alquiler alquilar = new Alquiler();
            alquilar.Usuario = (Usuario)Session["Usuario"];
            alquilar.Cancha = NegCancha.BuscarCancha(idCancha);
            alquilar.Horas = 1;
            alquilar.HoraAlquilada = horarioSeleccionado;
            alquilar.Fecha = fechaSeleccionada;
            alquilar.Costo = alquilar.Cancha.Precio * alquilar.Horas;
            

            MercadoLibre mercadoPago = new MercadoLibre();

            if(listMetodoPago.SelectedValue != "Efectivo")
            {
                alquilar.Estado = new EstadoAlquiler(3);
                mercadoPago.Pagar(alquilar);
            }
            else
            {
                alquilar.Estado = new EstadoAlquiler(1);
            }

            alquiNegocio.Agregar(alquilar);             

            Response.Redirect("MisAlquileres.aspx");           

        }

        protected void listDias_TextChanged(object sender, EventArgs e)
        {
            
            
        }

    }
}