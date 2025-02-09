using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    public class CuentaRol
    {
        private int id;
        private string rol;
        private string mail;

        public CuentaRol()
        {

        }

        public CuentaRol(int id, string rol, string mail)
        {
            this.id = id;
            this.rol = rol;
            this.mail = mail;
        }

        public int Id { get => id; set => id = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
