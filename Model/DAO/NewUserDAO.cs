using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver2._0.Model.DAO
{
    internal class NewUserDAO : ConeccionDAO
    {
        string confirmacion;
        MySqlCommand command;
        MySqlDataReader reader;

        public void AddUser(string nombre, string apellido, string correo, string contraseña)
        {
            command = new MySqlCommand("CALL INSERT_TB_USUARIO ('"+nombre+"','"+apellido+"','"+correo+"','"+contraseña+"')", coneccion);

            try
            {
                coneccion.Open();
                reader = command.ExecuteReader();

            }
            catch
            {
                MessageBox.Show("Error alintentar ingresar el usuario","Error",MessageBoxButtons.OK);
            }


        }
    }
}
