using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PasswordSaver2._0.Controller;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver2._0.View
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            UserController controller = new UserController(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
