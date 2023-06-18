using Login;
using PasswordSaver2._0.Model.DAO;
using PasswordSaver2._0.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver2._0.Controller
{
    internal class CrearCuentaController
    {
        private const bool V = true;
        CrearCuenta controller;
        public CrearCuentaController(CrearCuenta nuevoUsuario)
        {
            controller = nuevoUsuario;

            //Cancel
            #region Cancelar
            controller.btnCancelar.Click += new EventHandler(Cancelar);
            #endregion

            //Create new user
            #region
            controller.btnOk.Click += new EventHandler(NewUser);
            #endregion

            //Text Box funtions
            #region Fuciones de los text boxes
            controller.txbNombre.GotFocus += new EventHandler(HideName);
            controller.txbNombre.LostFocus += new EventHandler(HideName);
            //
            controller.txbApellido.GotFocus += new EventHandler(HideLastName);
            controller.txbApellido.LostFocus += new EventHandler(HideLastName);
            //
            controller.txbCorreo.GotFocus += new EventHandler(HideMail);
            controller.txbCorreo.LostFocus += new EventHandler(HideMail);
            //
            controller.txbContraseña.GotFocus += new EventHandler(HidePassword);
            controller.txbContraseña.LostFocus += new EventHandler(HidePassword);
            #endregion
        }

        //Cancel
        #region Cancelar
        private void Cancelar (object sender,EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
            controller.Close();
            
        }
        #endregion

        //Create new user
        #region crear usuario
        private void NewUser(object sender, EventArgs e)
        {
            if (controller.txbNombre.Text != "Nombre" && controller.txbApellido.Text != "Apellido" && controller.txbCorreo.Text != "Correo" && controller.txbContraseña.Text != "Contraseña")
            {
                MessageBox.Show("try done");
                NewUserDAO user = new NewUserDAO();
                user.AddUser(controller.txbNombre.Text, controller.txbApellido.Text, controller.txbCorreo.Text, controller.txbContraseña.Text);
            }
            else MessageBox.Show("try undone");


        }
        #endregion

        //Text Box funtions
        #region Funciones de los TextBoxes

        //Borrar el texto por defecto de los text boxes
        private void HideName(object sender, EventArgs e)
        {
            
            //Text Box Nombre
            if (controller.txbNombre.Text == "Nombre")
            {
                controller.txbNombre.Text = string.Empty;
            }
            else if(controller.txbNombre.Text == string.Empty)
                controller.txbNombre.Text = "Nombre";
        }
        private void HideLastName(object sender, EventArgs e)
        {
            //Text Box Apellido
            if (controller.txbApellido.Text == "Apellido")
            {
                controller.txbApellido.Text = string.Empty;
            }
            else if (controller.txbApellido.Text == string.Empty)
                controller.txbApellido.Text = "Apellido";
        }
        private void HideMail(object sender, EventArgs e)
        {
            //Text Box Correo
            if (controller.txbCorreo.Text == "Correo")
            {
                controller.txbCorreo.Text = string.Empty;
            }
            else if (controller.txbCorreo.Text == string.Empty)
                controller.txbCorreo.Text = "Correo";
        }
        private void HidePassword(object sender, EventArgs e)
        {
            //Contraseña
            if (controller.txbContraseña.Text == "Contraseña")
            {
                controller.txbContraseña.UseSystemPasswordChar = V;

            }
            else if (controller.txbContraseña.Text == string.Empty)
                controller.txbContraseña.UseSystemPasswordChar = false;
            controller.txbContraseña.Text = "Contraseña";
        }

        #endregion

        //seguridad
        #region
        //este metodo verifica que los textbox no esten vacios a la hora de presionar acceptar
        private void checker() 
        {
 
        }
        #endregion

    }
}
