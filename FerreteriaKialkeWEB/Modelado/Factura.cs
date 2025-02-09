namespace FerreteriaKialkeWEB.Modelado
{
    public class Factura
    {
        public int Id_Factura { get; set; }
        public DateTime FechaEmision { get; set; }
        public string MetodoPago { get; set; }
        public decimal Total { get; set; }
        public decimal Iva { get; set; }

        public int Id_Cliente { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<DetalleFactura> DetalleFacturas { get; set; }

    }
}
