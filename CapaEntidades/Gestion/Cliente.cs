using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Cliente {

        private int idCliente;
        private int idCuenta;
        private string cedula;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string telefono;


        public Cliente()
        {

        }


        public Cliente(int idCuenta, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string telefono)
        {
            IdCuenta = idCuenta;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }

        public Cliente(int idCliente, int idCuenta, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string telefono)
        {
            IdCliente = idCliente;
            IdCuenta = idCuenta;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}