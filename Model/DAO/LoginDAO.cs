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
        MySqlDataReader reader;
        MySqlCommand command;
        bool validation;
        List<UserDTO> UserList = new List<UserDTO>();

        #region validation
        public bool Validation(string email, string password)
        {

            command = new MySqlCommand("SELECT * FROM TB_USUARIO WHERE correo = '" + email + "' AND contraseña = SHA2('" + password + "',256)", coneccion);



            try
            {
                coneccion.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    validation = true;

                    while (reader.Read())
                    {
                        UserList.Add(new UserDTO
                        {
                            ID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Correo = reader.GetString(3),
                            Contraseña = reader.GetString(4),
                            Fecha_Creacion = reader.GetDateTime(5)
                        });
                    }
                }
            }
            catch
            {
                validation = false;
            }

            reader.Close();
            coneccion.Close();

            return validation;
        }
        #endregion
        public List<UserDTO> GetUsers()
        {
            return UserList;
        }
    }
}
