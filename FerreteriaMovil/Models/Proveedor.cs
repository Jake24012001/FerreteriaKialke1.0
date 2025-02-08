using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class Proveedor
    {
        private int Id_Proveedor { get; set; }
        private int Id_Empresa { get; set; }
        private string Nombre { get; set; }
        private string Telefono { get; set; }
        private string Mail { get; set; }
        private string Observacion { get; set; }

        public Proveedor(int id_Proveedor, int id_Empresa, string nombre, string telefono, string mail, string observacion)
        {
            Id_Proveedor = id_Proveedor;
            Id_Empresa = id_Empresa;
            Nombre = nombre;
            Telefono = telefono;
            Mail = mail;
            Observacion = observacion;
        }
    }
}
