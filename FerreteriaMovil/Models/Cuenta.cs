using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class Cuenta
    {
        public int Id_Cuenta { get; set; }
        public int Id_rol { get; set;}
        public string Mail { get; set; }
        public string Password { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(string mail, string password)
        {
            Mail = mail;
            Password = password;
        }

        public Cuenta(int id_Cuenta, int id_rol, string mail, string password)
        {
            Id_Cuenta = id_Cuenta;
            Id_rol = id_rol;
            Mail = mail;
            Password = password;
        }
    }
}
