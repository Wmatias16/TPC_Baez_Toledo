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
    public partial class Configuracion : System.Web.UI.Page
    {
        Usuario user = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                user = (Usuario)Session["Usuario"];
            }

            if (!IsPostBack)
            {
                txtEmail.Text = user.Email;
                txtNombre.Text = user.Nombre;
                txtApellido.Text = user.Apellidos;
                txtTelefono.Text = user.Telefono;
            }
        }
        private string encriptarSHA1(string vsValue)
        {
            System.Security.Cryptography.HashAlgorithm hashValue = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            // Convert the original string to array of Bytes
            byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(vsValue);

            // Compute the Hash, returns an array of Bytes
            byte[] byteHash = hashValue.ComputeHash(byteValue);

            hashValue.Clear();

            // Return a base 64 encoded string of the Hash value
            return (Convert.ToBase64String(byteHash));
        }


        protected void btnEmail_Click(object sender, EventArgs e)
        {
            UsuarioNegocio userNegocio = new UsuarioNegocio();

            if (!userNegocio.Existe(txtEmail.Text))
            {
                user.Email = txtEmail.Text;
                userNegocio.Editar(user);
            }
        }

        protected void btnContraseña_Click(object sender, EventArgs e)
        {
            UsuarioNegocio userNegocio = new UsuarioNegocio();

            if (encriptarSHA1(txtContraActual.Text) == user.Contraseña)
            {
                if (txtContraNueva.Text == txtContraConfirm.Text)
                {
                    user.Contraseña = encriptarSHA1(txtContraNueva.Text);
                    userNegocio.Editar(user);
                }
            }
        }

        protected void btnDatos_Click(object sender, EventArgs e)
        {
            UsuarioNegocio userNegocio = new UsuarioNegocio();

            if (txtNombre.Text != null && txtApellido.Text != null && txtTelefono.Text != null)
            {
                user.Nombre = txtNombre.Text;
                user.Apellidos = txtApellido.Text;
                user.Telefono = txtTelefono.Text;
                userNegocio.Editar(user);
            }
        }


    }
}