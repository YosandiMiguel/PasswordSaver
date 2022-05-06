using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordSaver2._0.Model.DAO;
using PasswordSaver2._0.View;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Controller
{
    class UserController
    {
        App appController;

        public UserController(App view)
        {
            appController = view;
            appController.Load += new EventHandler(UserInformation);
        }

        private void UserInformation(object sender,EventArgs e)
        {
            UserDAO user = new UserDAO();
            appController.dataGridView1.DataSource = user.GetUsers();
        }
    }
}
