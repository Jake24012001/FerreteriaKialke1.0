using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Cuenta
    {
        private int idCuenta;
        private int idrol;
        private string mail;
        private string password;

        

        public Cuenta()
        {

        }

        public Cuenta(int idRol ,string mail, string password)
        {
            Id_rol = idRol;
            Mail = mail;
            Password = password;
        }

        public int Id_Cuenta { get => idCuenta; set => idCuenta = value; }
        public int Id_rol { get => idrol; set => idrol = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}