﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {                        
            CanchaNegocio canchaNegocio = new CanchaNegocio();
            canchas = canchaNegocio.Listar();     
        }

        protected void ObtenerHorario(Object sender, EventArgs e)
        {

        }


    }
}