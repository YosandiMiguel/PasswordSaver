using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordSaver2._0.View;
using PasswordSaver2._0.Model.DAO;
using System.Threading.Tasks;
using PasswordSaver2._0.Model.DTO;

namespace PasswordSaver2._0.Controller
{
    class UserController
    {
        App appController;
        List<UserDTO> userInformation = new List<UserDTO>();
        public UserController(App view)
        {
            appController = view;
            appController.Load += new EventHandler(UserInformation);
        }

        private void UserInformation(object sender, EventArgs e)
        {
            UsersDAO information = new UsersDAO();
            userInformation.AddRange(information.userList(LoginDAO.ID));
            appController.LblName.Text = userInformation[UsersDAO.position].Nombre;

        }
    }
}
