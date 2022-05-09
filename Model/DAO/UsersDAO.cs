using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using PasswordSaver2._0.Model.DTO;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Model.DAO
{
    class UsersDAO:ConeccionDAO
    {
        MySqlDataReader reader;
        MySqlCommand command;
        List<UserDTO> users = new List<UserDTO>();

        public List<UserDTO> userList(int ID)
        {
            command = new MySqlCommand("SELECT * FROM TB_USUARIO WHERE ID = "+ID+" ", coneccion);

            try
            {
                coneccion.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new UserDTO { ID = reader.GetInt32(0),
                                                Nombre = reader.GetString(1),
                                                Apellido = reader.GetString(2),
                                                Correo = reader.GetString(3),
                                                Contraseña = reader.GetString(4)});
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return users;
        }
    }
}
