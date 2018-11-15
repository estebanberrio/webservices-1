using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ws.mysql
{
    class conexion
    {
        public static bool prueba;

        public static MySqlConnection obtenerconexion()
        {

            MySqlConnection conexion = new MySqlConnection("server=localhost; database=ws; Uid=root; pwd=; SslMode=none; charset=utf8; convert zero datetime=True; Allow zero datetime=true;");
            //conexion.Open();

            try
            {
                conexion.Open();
                prueba = true;
            }
            catch (Exception)
            {
                prueba = false;
            }
            return conexion;
        }
    }
}
