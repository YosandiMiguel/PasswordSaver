﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSaver2._0.Controller.Login_Controller;

namespace PasswordSaver2._0
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            LoginController MyController = new LoginController(this);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
