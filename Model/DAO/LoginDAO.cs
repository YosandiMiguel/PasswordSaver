using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using PasswordSaver2._0.Model.DTO;
using System.Windows.Forms;

namespace PasswordSaver2._0.Model.DAO
{
    class LoginDAO : ConeccionDAO
    {
        public static int ID;
        MySqlDataReader reader;
        MySqlCommand command;
        bool validation;

        #region validation
        public bool Validation(string email, string password)
        {

            command = new MySqlCommand("SELECT ID FROM TB_USUARIO WHERE correo = '" + email + "' AND contraseña = SHA2('" + password + "',256)", coneccion);

            

            try
            {
                coneccion.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    validation = true;

                    while (reader.Read())
                    {
                        ID = reader.GetInt32(0);
                    }

                }
            }
            catch
            {
                validation = false;
            }

            //reader.Close();
            coneccion.Close();

            return validation;
        }
        #endregion
    }
}
