using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace GVP.UTIL
{
    public class AccesoBD
    {

        public static MySqlConnection ObtenerConexion()
        {
            string test = System.Environment.GetEnvironmentVariable("GVPP");
            string test2 = System.Environment.GetEnvironmentVariable("GVPU");
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdhallazgos; " +
            "Uid="+System.Environment.GetEnvironmentVariable("GVPU")+"; pwd="+System.Environment.GetEnvironmentVariable("GVPP")+";");
            conectar.Open();

            return conectar;
        }

    }
}