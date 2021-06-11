using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GVP.UTIL;
using GVP.SERVICE;

namespace GVP.VIEW
{
    
    public partial class Login : System.Web.UI.Page
    {
        Usuario_Service usuario_service = new Usuario_Service();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = Validaciones.XSS(tbUsuario.Text);
            string pass = Validaciones.XSS(tbPass.Text);

            if(usuario.Contains("error") || pass.Contains("error"))
            {

            }
            else
            {
                if (usuario_service.ValidarUsuario(usuario, pass))
                {
                    Server.Transfer("Index.aspx");
                }
                else
                {
                    tbUsuario.Text = "falló";
                }

            }
        }
    }
}