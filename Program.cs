using Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PasswordSaver2._0.View;
using System.Windows.Forms;

namespace PasswordSaver2._0
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }
    }
}
