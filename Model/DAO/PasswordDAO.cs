using MySql.Data.MySqlClient;
using PasswordSaver2._0.Controller;
using PasswordSaver2._0.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver2._0.Model.DAO
{
    internal class PasswordDAO : ConeccionDAO
    {
        //int id;
        MySqlCommand command;
        MySqlDataReader reader;
        List<ViewPasswordDTO> generictlist = new List<ViewPasswordDTO>();

        public List<ViewPasswordDTO> Information()
        {
            command = new MySqlCommand("SELECT * from vista_Principal where ID_Usuario = " + LoginDAO.ID + "", coneccion);

            try
            {
                coneccion.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        generictlist.Add(new ViewPasswordDTO
                        {
                            ID = reader.GetInt32(0),
                            Plataforma = reader.GetString(1),
                            Contraseña = reader.GetString(2)

                        });
                    }



                }


            }
            catch
            {
                MessageBox.Show("Ocurrio un erro al intentar cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return generictlist;
        }

        private void DeleteButton(int id)
        {
            command = new MySqlCommand("CALL Delete_tb_Contraseñas()", coneccion);
            try
            {
                reader = command.ExecuteReader();
            }
            catch(Exception error)
            {
                MessageBox.Show(Convert.ToString(error), "Error");
            }
        }
    }

}



    






    
