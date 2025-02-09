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

        public Cuenta(int idCuenta, int idRol ,string mail, string password)
        {
            IdCuenta = idCuenta;
            Idrol = idRol;
            Mail = mail;
            Password = password;
        }

        public Cuenta(int idRol, string mail, string password)
        {
            Idrol = idRol;
            Mail = mail;
            Password = password;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int Idrol { get => idrol; set => idrol = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}