using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica2_CN_182310214
{
    class Conexion
    {
        public static SqlConnection cadena(string CadenaConexion)
        {
            SqlConnection con = new SqlConnection(@CadenaConexion);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
