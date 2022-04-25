using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver2._0.Model.DTO.Login
{
    class LoginDAO
    {
        //Propiedades 
        int _id;
        string _nombre;
        string _apellido;
        string _correo;
        string _contraseña;
        DateTime _fecha_Creacion;

     //Gets y Sets
        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public string Correo
        {

            get => _correo;
            set => _correo = value;
        }

        public string Contraseña
        {
            get => _contraseña;
            set => _contraseña = value;
        }

        public DateTime Fecha_Creacion
        {
            get => _fecha_Creacion;
            set => _fecha_Creacion = value;
        }
    }
}
