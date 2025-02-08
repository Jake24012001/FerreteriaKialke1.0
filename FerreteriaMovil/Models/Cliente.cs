﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class Cliente
    {
        private int Id_Cliente { get; set; }
        private int Id_Cuenta { get; set; }
        private string Cedula { get; set; }
        private string Nombres { get; set; }
        private string Apellidos { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private string Telefono { get; set; }

        public Cliente()
        {
        }

        public Cliente(string cedula, string nombres, string apellidos, DateTime fechaNacimiento, string telefono)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }

        public Cliente(int id_Cliente, int id_Cuenta, string cedula, string nombres, string apellidos, DateTime fechaNacimiento, string telefono)
        {
            Id_Cliente = id_Cliente;
            Id_Cuenta = id_Cuenta;
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
        }
    }
}
