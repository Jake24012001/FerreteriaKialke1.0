using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaKialke.CapaEntidades.Gestion
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
            Id_rol = 1;
        }

        
    }
}
