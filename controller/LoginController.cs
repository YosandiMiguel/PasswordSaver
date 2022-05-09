using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PasswordSaver2._0.Model.DAO;
using System.Threading.Tasks;
using Login;
using PasswordSaver2._0.View;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PasswordSaver2._0.Controller
{
    class LoginController
    {
        Form1 viewController;
        //Constructor
        public LoginController(Form1 view)
        {
            viewController = view;

            //Form Events
            #region Eventos de la forma

            viewController.MouseDown += new MouseEventHandler(Move_Form);
            viewController.btnMinimizar.Click += new EventHandler(Minimized);
            viewController.btnCerrar.Click += new EventHandler(Close);
            #endregion

            //Btn close and minimized
            #region botones cerrar y minimizar
            viewController.btnCerrar.MouseEnter += new EventHandler(ChangeColor_BtnClose_MouseInto);
            viewController.btnCerrar.MouseLeave += new EventHandler(ChangeColor_BtnClose_MouseOut);
            viewController.btnMinimizar.MouseEnter += new EventHandler(ChangeColor_BtnMinimized_MouseInto);
            viewController.btnMinimizar.MouseLeave += new EventHandler(ChangeColor_BtnMinimized_MouseOut);
            #endregion

            //Text Box
            #region Cuadros de texto
            viewController.txtUser.Enter += new EventHandler(Clean_TextBox_User);
            viewController.txtUser.Leave += new EventHandler(Water_Mark_User);
            viewController.txtPass.Enter += new EventHandler(Clean_Textbox_Password);
            viewController.txtPass.Leave += new EventHandler(Water_Mark_Password);
            #endregion

            //Sing in
            #region
            viewController.btnAcceder.Click += new EventHandler(Acceder);
            #endregion
        }

        //Move window
        #region mover ventana 


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Move_Form(object sender, MouseEventArgs e)
        {


            ReleaseCapture();
            SendMessage(viewController.Handle, 0x112, 0xf012, 0);

        }

        #endregion


        //Close form and minimized
        #region Cerrar y minimizar forma
        private void Minimized(object sender, EventArgs e)
        {
            viewController.WindowState = FormWindowState.Minimized;
        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        //Change color with the mouse
        #region cambio de color con el puntero

        private void ChangeColor_BtnClose_MouseInto(object sender, EventArgs e)
        {
            viewController.btnCerrar.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void ChangeColor_BtnClose_MouseOut(object sender, EventArgs e)
        {
            viewController.btnCerrar.BackColor = Color.FromArgb(15, 15, 15);
        }

        private void ChangeColor_BtnMinimized_MouseInto(object sender, EventArgs e)
        {
            viewController.btnMinimizar.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void ChangeColor_BtnMinimized_MouseOut(object sender, EventArgs e)
        {
            viewController.btnMinimizar.BackColor = Color.FromArgb(15, 15, 15);
        }
        #endregion

        //Text boxes
        #region Cuadros de texto

        private void Clean_TextBox_User(object sender, EventArgs e)
        {
            if (viewController.txtUser.Text == "USUARIO")
            {

                viewController.txtUser.Text = string.Empty;
                viewController.txtUser.ForeColor = Color.LightGray;
            }
        }

        private void Water_Mark_User(object sender, EventArgs e)
        {
            if (viewController.txtUser.Text == string.Empty)
            {
                viewController.txtUser.Text = "USUARIO";
                viewController.txtUser.ForeColor = Color.DimGray;
            }
        }


        private void Clean_Textbox_Password(object sender, EventArgs e)
        {
            if (viewController.txtPass.Text == "CONTRASEÑA")
            {
                viewController.txtPass.Text = string.Empty;
                viewController.txtPass.UseSystemPasswordChar = true;
                viewController.txtPass.ForeColor = Color.LightGray;

            }
        }

        private void Water_Mark_Password(object sender, EventArgs e)
        {
            if (viewController.txtPass.Text == string.Empty)
            {
                viewController.txtPass.UseSystemPasswordChar = false;
                viewController.txtPass.Text = "CONTRASEÑA";
                viewController.txtPass.ForeColor = Color.DimGray;
            }
        }
        #endregion

        //Sing in
        #region Inicio de secion
        private void Acceder(Object sender, EventArgs e)
        {
            bool validation;
            LoginDAO user = new LoginDAO();
            validation = user.Validation(viewController.txtUser.Text, viewController.txtPass.Text);

            if (validation)
            {

                App singIn = new App();
                singIn.Show();
                viewController.Hide();
            }
            else
                viewController.lblIncorrect.Visible = true;


        }
        #endregion
    }

}


