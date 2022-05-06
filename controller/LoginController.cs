using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordSaver2._0.Model.DAO;
using PasswordSaver2._0.View;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Controller
{
    class LoginController
    {
        Login refence_view;

        public LoginController(Login view)
        {
            refence_view = view;
            refence_view.Load += new EventHandler(Show);
;        }

        private void Show(Object sender,EventArgs e)
        {
            UserDAO userInformation = new UserDAO();

            refence_view.DGVtest.DataSource = userInformation.Login("el_yosandi_reyes", "eab47a662ac21299cf96aba2ab1b1485a09b5ae2ef6d6e3a71736cb4704dfaba");
        }

    }
}
