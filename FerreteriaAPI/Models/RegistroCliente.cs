namespace FerreteriaAPI.Models
{
    public class RegistroCliente
    {
        public int Id_Cliente { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }

        // Relación uno a uno con Cuenta
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

        // Relación uno a muchos con Factura
        public ICollection<Factura> Facturas { get; set; }
    }
}
