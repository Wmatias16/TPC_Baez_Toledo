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
    public partial class Page_admin : System.Web.UI.Page
    {
        public List<Usuario> clientes = new List<Usuario>();

        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioNegocio userNegocio = new UsuarioNegocio();

            clientes = userNegocio.Listar();
        }
    }
}
