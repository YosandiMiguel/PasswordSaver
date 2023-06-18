using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Model.DTO
{
    internal class ViewPasswordDTO
    {
        private int _id;
        private string _plataforma;
        private string _contraseña;


        public int ID { get { return _id; } set { _id = value; } }
        public string Plataforma { get { return _plataforma; } set { _plataforma = value; }}
        public string Contraseña { get { return _contraseña;  } set { _contraseña = value; } }

    }
}
