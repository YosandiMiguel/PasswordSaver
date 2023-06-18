using PasswordSaver2._0.View.Children;
using PasswordSaver2._0.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PasswordSaver2._0.Model.DAO;
using System.Collections.Generic;
using PasswordSaver2._0.Model.DTO;
using MySqlX.XDevAPI.Relational;

namespace PasswordSaver2._0.Controller.Children_controller
{
    class PasswordController
    {
        static Passwords controller;
        public PasswordController(Passwords view)
        {
            controller = view;
            controller.Load += new EventHandler(LoadPasswords);
            controller.DgvPasswords.CellClick += new DataGridViewCellEventHandler(DeleteButton);
        }

        public void position(object sender, EventArgs e)
        {
            MessageBox.Show(controller.btnShow.Location.ToString());
        }
        #region Movimientos de los botones
        public static void buttonPositionChanger()
        {
            if (UserController.menuState == true && UserController.formState == true)
            {
                int less = 25;
                controller.btnShow.Location = new Point(1013, 234);
                controller.btnAdd.Location = new Point(1013, 359);
                controller.btnModify.Location = new Point(1013, 484);
                controller.btnDelete.Location = new Point(1013, 609);

                
            }
            else if (UserController.menuState == false && UserController.formState == true)
            {
                
                controller.btnShow.Location = new Point(1128, 234);
                controller.btnAdd.Location = new Point(1128, 359);
                controller.btnModify.Location = new Point(1128, 484);
                controller.btnDelete.Location = new Point(1128, 609);
            }

        }
        public static void ButtonOriginalPosition()
        {
            if (UserController.menuState == true && UserController.formState == false)
            {
                controller.btnShow.Location = new Point(430, 66);
                controller.btnAdd.Location = new Point(430, 141);
                controller.btnModify.Location = new Point(430, 216);
                controller.btnDelete.Location = new Point(430, 291);
            }
            else if (UserController.menuState == false && UserController.formState == false)
            {
                controller.btnShow.Location = new Point(575, 66);
                controller.btnAdd.Location = new Point(575, 141);
                controller.btnModify.Location = new Point(575, 216);
                controller.btnDelete.Location = new Point(575, 291);
            }

        }
        #endregion

        #region cargar contraseñas

        public static void LoadPasswords(object sender, EventArgs e)
        {
            //cargando contraseñas y mostrandolas en el DataGridView
            PasswordDAO passwordLoader = new PasswordDAO();
            controller.DgvPasswords.DataSource = passwordLoader.Information();


        }

        #endregion

        //Delete 
        #region
        private void DeleteButton(object sender, EventArgs e)
        {
            var SelectedRow = controller.DgvPasswords.CurrentRow;
            if(SelectedRow != null)
            {
                var valueSelected =Convert.ToString(SelectedRow.Cells[0].Value);
                MessageBox.Show(valueSelected);
            }
        }
        #endregion

    }
}
