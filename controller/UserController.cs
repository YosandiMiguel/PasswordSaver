using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordSaver2._0.View;
using PasswordSaver2._0.Model.DAO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSaver2._0.Model.DTO;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using PasswordSaver2._0.View.Children;


namespace PasswordSaver2._0.Controller
{
    class UserController
    {
        private Form childInstance;
        //size
        readonly int menuPanelWidth = 213;
      

        App appController;
        List<UserDTO> userInformation = new List<UserDTO>();

        public UserController(App view)
        {
            //Loading form
            #region cargando forma
            appController = view;
            appController.Load += new EventHandler(UserInformation);
            #endregion

            //Close, open and minimized
            #region Cerrar, abrir, restaurarl tamaño original y minimizar
            appController.PcbExit.Click += new EventHandler(this.Close);
            appController.PcbMinimized.Click += new EventHandler(Minimized);
            appController.PcbMaximized.Click += new EventHandler(Maximized);
            #endregion
            //Menu
            #region Menu

            appController.PcbMenu.Click += new EventHandler(CloseMenu);
            appController.PcbMenu.MouseEnter += new EventHandler(ChangeImagePcbMenuStart);
            appController.PcbMenu.MouseLeave += new EventHandler(ChangeImagePcbMenuEnd);

            //Opening forms children
            appController.PcbSchedule.Click += new EventHandler(OpenSchelude);
            appController.PcbSetting.Click += new EventHandler(OpenSetting);
            appController.PcbPasswords.Click += new EventHandler(OpenPasswords);
            
            #endregion


        }

        //Initialize form
        #region Inicializando forma
        private void UserInformation(object sender, EventArgs e)
        {
            UsersDAO information = new UsersDAO();
            userInformation.AddRange(information.userList(LoginDAO.ID));
            appController.LblName.Text = userInformation[UsersDAO.position].Nombre;
            appController.LblMail.Text = userInformation[UsersDAO.position].Correo;
        }
        #endregion

        //Close, open and minimized
        #region Cerrar, maximizar, restaurar a tamaño normal y minimizar
        private void Close(object sender,EventArgs e)
        {
            appController.Close();
        }
        private void Minimized(object sender,EventArgs e)
        {
            appController.WindowState = FormWindowState.Minimized;
        }

        private void Maximized(object sender,EventArgs e)
        {
            if (appController.WindowState == FormWindowState.Maximized)
            {
                appController.WindowState = FormWindowState.Normal;
            }
            else 
                appController.WindowState = FormWindowState.Maximized;
        }

        #endregion

        //Menu
        #region Menu
        //moving LeftPanel
        private void CloseMenu(object sender,EventArgs e)
        {

            if (appController.LeftPanel.Width == menuPanelWidth)
            {
                appController.LeftPanel.Width = 71;
                appController.PcbMenu.Location = new Point(15,6);

                //Hiding icons
                appController.PcbPasswords.Visible = false;
                appController.PcbSchedule.Visible = false;
                appController.PcbSetting.Visible = false;
                appController.PcbLogOut.Visible = false;

                //Changing image(Picturebox menu)
                appController.PcbMenu.Image = Image.FromFile("C:/Users/Yosandi Miguel Reyes/source/repos/PasswordSaver2.0/Resources/icons8-menu-39.png");
                
                
            }
            else
            {
                appController.LeftPanel.Width = menuPanelWidth;
                appController.PcbMenu.Location = new Point(171, 6);

                //showing icons
                appController.PcbPasswords.Visible = true;
                appController.PcbSchedule.Visible = true;
                appController.PcbSetting.Visible = true;
                appController.PcbLogOut.Visible = true;

                //Changing image(Picturebox menu)
                appController.PcbMenu.Image = Image.FromFile("C:/Users/Yosandi Miguel Reyes/source/repos/PasswordSaver2.0/Resources/icons8-double-left-39.png");
                
            }
        }

        //image cahnger
        private void ChangeImagePcbMenuStart(object sender,EventArgs e)
        {
            if(appController.PcbMenu.Location.X == 15)
            {
                appController.PcbMenu.Image = Image.FromFile("C:/Users/Yosandi Miguel Reyes/source/repos/PasswordSaver2.0/Resources/icons8-menu.gif");

            }
        } 
        private void ChangeImagePcbMenuEnd(object sender, EventArgs e)
        {
            if (appController.PcbMenu.Location.X == 15)
            {
                appController.PcbMenu.Image = Image.FromFile("C:/Users/Yosandi Miguel Reyes/source/repos/PasswordSaver2.0/Resources/icons8-menu-39.png");
            }
        }
        private void OpenChildForm(Form child)
        {
            
            if (childInstance != null)
            {
                //Only one instance
                childInstance.Close();
            }
            childInstance = child;
            child.Dock = DockStyle.Fill;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            appController.panelChild.Controls.Add(child);
            child.Tag = "Child";
            child.BringToFront();
            child.Show();

        }

        //Opening forms
        private void OpenSchelude(object sender, EventArgs e)
        {
            OpenChildForm(new Schelude());
            appController.LblTitle.Text = "Schelude";
        }
        private void OpenPasswords(object sender, EventArgs e)
        {
            OpenChildForm(new Passwords());
            appController.LblTitle.Text = "Passwords";
        }
        private void OpenSetting (object sender, EventArgs e)
        {
            OpenChildForm(new Setting());
            appController.LblTitle.Text = "Setting";
        }
        
        #endregion


    }
}
