using System;

using System.Windows.Forms;
using PasswordSaver2._0.Controller.Children_controller;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordSaver2._0.View.Children
{
    public partial class Passwords : Form
    {
        public Passwords()
        {
            InitializeComponent();

            PasswordController controlled = new PasswordController(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DgvPasswords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
