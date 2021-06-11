using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVP.UTIL
{
    public class Validaciones
    {
        
        public static string XSS(string cadena)
        {   
            try
            {
                string malicioso = "";
                for (int i = 0; i < Variables.caracteres_maliciosos.Count(); i++)
                {
                    malicioso = Variables.caracteres_maliciosos[i];
                    if(cadena.Contains(Variables.caracteres_maliciosos[i]))
                    {
                        cadena.Replace(Variables.caracteres_maliciosos[i], "");
                    }
                }
            }
            catch (Exception ex)
            {
                UTIL.CREARLOG("Validaciones - XSS: "+ cadena + "\n" + ex.Message);
                cadena = "error";
            }
            return cadena;
        }
    }
}