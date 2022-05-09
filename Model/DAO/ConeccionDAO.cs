using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Model.DAO
{
    class ConeccionDAO
    {
        protected MySqlConnection coneccion = new MySqlConnection(ConfigurationManager.ConnectionStrings["SqlConection"].ConnectionString); 
    }
}
