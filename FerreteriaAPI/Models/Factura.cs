namespace FerreteriaAPI.Models
{
    public class Factura
    {
        public int Id_Factura { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string MetodoPago { get; set; }
        public decimal Total { get; set; }
        public decimal Iva { get; set; }

        // Llave foránea para la relación muchos a uno con RegistroCliente
        public int RegistroClienteId { get; set; }
        public RegistroCliente RegistroCliente { get; set; }

        // Relación uno a muchos con DetalleFactura
        public ICollection<DetalleFactura> Detalle { get; set; } = new List<DetalleFactura>();
    }
}
