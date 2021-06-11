using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GVP.UTIL
{
    public class UTIL
    {
        public static void CREARLOG(string mensaje)
        {
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(Variables.URL_LOG, true);
                file.WriteLine(DateTime.Now + " : " + mensaje);
                file.Close();
               
            }
            catch (Exception ex)
            {

            }

        }

    }
}