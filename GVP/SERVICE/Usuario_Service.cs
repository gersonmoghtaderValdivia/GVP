using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVP.SERVICE
{
    public class Usuario_Service
    {

        public bool ValidarUsuario(string usr, string pass)
        {
            bool resultado = true;
            try
            {
                resultado = MODEL.Usuario_DAO.ValidarUsuario(usr, pass);

            }
            catch (Exception ex)
            {
                resultado = false;
                UTIL.UTIL.CREARLOG("Usuario_Service-ValidarUsuarioService: " + ex.Message);
            }
            return resultado;
        }

    }
}