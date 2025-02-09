using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    public class ProveedorEmpresa
    {
        private int id;
        private string empresa;
        private string proveedor;
        private DateTime fechaNacimiento;
        private int edad;
        private string mail;
        private string telefono;
        private string observacion;

        public ProveedorEmpresa()
        {

        }

        public ProveedorEmpresa(int id, string empresa, string proveedor, DateTime fechaNacimiento, int edad, string mail, string telefono, string observacion)
        {
            this.id = id;
            this.empresa = empresa;
            this.proveedor = proveedor;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.mail = mail;
            this.telefono = telefono;
            this.observacion = observacion;
        }

        public int Id { get => id; set => id = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
