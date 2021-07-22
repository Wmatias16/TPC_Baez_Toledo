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
    public partial class Page_admin : System.Web.UI.Page
    {
        public List<Alquiler> AlquileresDiaHoy = new List<Alquiler>();
        public List<Alquiler> AlquileresPendientes = new List<Alquiler>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(Session["Usuario"] != null && ((Usuario)Session["Usuario"]).Rol.Nombre == "Administrador")
            {
                AlquilerNegocio alquiler = new AlquilerNegocio();
                AlquileresDiaHoy = alquiler.ListarProxTurno(DateTime.Now.ToString("yyyy-MM-dd"));
                   
                AlquileresPendientes = alquiler.ListarPendientes();
                Repetidor.DataSource = AlquileresPendientes;
                Repetidor.DataBind();               
               
            }
            else
            {
                Response.Redirect("Error.aspx");
            }

            
        }
      

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(((LinkButton)sender).CommandArgument);
            AlquilerNegocio alquiNegocio = new AlquilerNegocio();
            List<Alquiler> pendientes = alquiNegocio.ListarPendientes();
            
            Alquiler detalle = pendientes.Find(x => x.Id == id);

            lblModalTitle.Text = detalle.Cancha.Nombre;
            txtNombre.Text = detalle.Usuario.Nombre;
            txtApellido.Text = detalle.Usuario.Apellidos;
            txtPagar.Text = detalle.Costo.ToString();


            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }

        protected void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((LinkButton)sender).CommandArgument);

            AlquilerNegocio alquiNegocio = new AlquilerNegocio();

            alquiNegocio.CambiarEstado(id, 5);

            AlquileresPendientes = alquiNegocio.ListarPendientes();
            Session["Pendientes"] = AlquileresPendientes;
            Repetidor.DataSource = AlquileresPendientes;
            Repetidor.DataBind();
        }

        protected void btnCancelarAlquiler_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((LinkButton)sender).CommandArgument);

            AlquilerNegocio alquiNegocio = new AlquilerNegocio();

            alquiNegocio.CambiarEstado(id, 4);

            AlquileresPendientes = alquiNegocio.ListarPendientes();
            Repetidor.DataSource = AlquileresPendientes;
            Repetidor.DataBind();
        }
    }
}
