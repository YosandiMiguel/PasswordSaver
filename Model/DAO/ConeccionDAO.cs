using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Model.DAO
{
    class ConeccionDAO
    {
        protected MySqlConnection coneccion = new MySqlConnection("datasource = 127.0.0.1; port=3306;username=root;password=;database=pruebaconeccion;");
    }
}
