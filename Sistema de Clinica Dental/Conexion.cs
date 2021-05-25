using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_Clinica_Dental
{
    public class ConexionALaBD
    {
        public static MySqlConnection conectar()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=;");
            //conectar.Open();
            return conectar;
        }
    }
}
