using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Proveedor
    {
        private int idProveedor;
        private int idEmpresa;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad;
        private string mail;
        private string telefono;
        private string observacion;


        public Proveedor()
        {

        }

        public Proveedor(int idProveedor, int idEmpresa, string nombre, string apellido, DateTime fechaNacimiento, int edad, string mail, string telefono, string observacion)
        {
            this.idProveedor = idProveedor;
            this.idEmpresa = idEmpresa;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.mail = mail;
            this.telefono = telefono;
            this.observacion = observacion;
        }

        public Proveedor(int idEmpresa, string nombre, string apellido, DateTime fechaNacimiento, int edad, string mail, string telefono, string observacion)
        {
            this.idEmpresa = idEmpresa;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.mail = mail;
            this.telefono = telefono;
            this.observacion = observacion;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }

    }
}
