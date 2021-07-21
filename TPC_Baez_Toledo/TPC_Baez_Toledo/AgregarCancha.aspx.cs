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
    public partial class WebForm3 : System.Web.UI.Page
    {
        CanchaNegocio CanchaNeg = new CanchaNegocio();
        TipoCanchaNegocio TipoNeg = new TipoCanchaNegocio();

        public string linkImg = "./Img/Cancha.jpg";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null &&((Usuario)Session["Usuario"]).Rol.Nombre == "Administrador")
            {
                List<TipoCancha> Tipos = new List<TipoCancha>();
                Tipos = TipoNeg.ListarTipoCancha();

                foreach (TipoCancha item in Tipos)
                {
                    ListTipoCancha.Items.Add(item.Nombre);
                }

                if (!IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        Cancha NewCancha = new Cancha();

                        NewCancha = CanchaNeg.BuscarCancha(int.Parse(Request.QueryString["id"]));
                        linkImg = NewCancha.UrlImagen;
                        TxtNombre.Text = NewCancha.Nombre;
                        TxtDescripcion.Text = NewCancha.Descripcion;
                        TxtPrecio.Text = NewCancha.Precio.ToString();
                        TxtUrlImagen.Text = NewCancha.UrlImagen;
                        ListTipoCancha.SelectedValue = NewCancha.TipoCancha.Nombre;
                    }
                }
            }
            else
            {
                Response.Redirect("Error.aspx");
            }         
        }

        protected void BtnAgregar(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Cancha newCancha = new Cancha();


                newCancha.Nombre = TxtNombre.Text;
                newCancha.Precio = Decimal.Parse(TxtPrecio.Text);
                newCancha.TipoCancha = TipoNeg.BuscarTipoCancha(ListTipoCancha.SelectedValue);
                newCancha.Descripcion = TxtDescripcion.Text;
                newCancha.UrlImagen = TxtUrlImagen.Text;

                CanchaNeg.Agregar(newCancha);
                Response.Redirect("GestionCanchas.aspx");
            }
           
        }
        protected void BtnEditar(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Cancha newCancha = new Cancha();

                newCancha.Id = int.Parse(Request.QueryString["id"]);
                newCancha.Nombre = TxtNombre.Text;
                newCancha.Precio = Decimal.Parse(TxtPrecio.Text);
                newCancha.TipoCancha = TipoNeg.BuscarTipoCancha(ListTipoCancha.SelectedValue);
                newCancha.Descripcion = TxtDescripcion.Text;
                newCancha.UrlImagen = TxtUrlImagen.Text;

                CanchaNeg.Editar(newCancha);
                Response.Redirect("GestionCanchas.aspx");
            }
           
        }

        

    }
}