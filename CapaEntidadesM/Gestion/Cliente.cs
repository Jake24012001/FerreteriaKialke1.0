using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Cliente
    {

        private int idCliente;
        private int idCuenta;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad;
        private string telefono;


        public Cliente()
        {

        }

        public Cliente(int idCliente, int idCuenta, string nombre, string apellido, DateTime fechaNacimiento, int edad, string telefono)
        {
            this.idCliente = idCliente;
            this.idCuenta = idCuenta;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.telefono = telefono;
        }

        public Cliente(int idCuenta, string nombre, string apellido, DateTime fechaNacimiento, int edad, string telefono)
        {
            this.idCuenta = idCuenta;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.telefono = telefono;
        }



        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}