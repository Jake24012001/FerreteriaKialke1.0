using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class Rol
    {
        private int Id_Rol { get; set; }
        private string Nombre { get; set; }

        public Rol(int id_Rol, string nombre)
        {
            Id_Rol = id_Rol;
            Nombre = nombre;
        }
    }
}
