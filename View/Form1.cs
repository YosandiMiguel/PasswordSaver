using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordSaver2._0.Controller;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoginController controller = new LoginController(this);

        }
<<<<<<< HEAD
=======

>>>>>>> 1ef45c122f8f82940baa55c2ea1010403a8e8311
    }
}
