using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace GVP.MODEL
{
    public class Usuario_DAO
    {

        public static bool ValidarUsuario(string usr, string pass)
        {
            bool respuesta = true;

            MySqlCommand sentencia = new MySqlCommand();
            string sql = "SELECT EXISTS (select * from usuarios where correo=@correo and contrasna=@contrasena) as existe";
            sentencia.Parameters.AddWithValue("@correo",usr);
            sentencia.Parameters.AddWithValue("@contrasena", pass);

            try
            {
                sentencia.Connection = UTIL.AccesoBD.ObtenerConexion();
                sentencia.CommandText = sql;
                MySqlDataReader consultar = sentencia.ExecuteReader();
                while(consultar.Read())
                {
                    if(Convert.ToInt32(consultar["existe"]) == 1)
                    {
                        respuesta = true;
                    }
                    else
                    {
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                UTIL.UTIL.CREARLOG("Usuario_DAO - validarUsuario: " + ex.Message); 
            }
            finally
            {
                sentencia.Connection.Close();
            }
            return respuesta;
        }

    }
}