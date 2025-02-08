namespace FerreteriaAPI.Models
{
    public class DetalleFactura
    {
        public int Id_Factura { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }
        public double Descuentos { get; set; }

        // Llave foránea para la relación muchos a uno con Factura
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        // Llave foránea para la relación muchos a uno con Producto
        public int Id_Producto { get; set; }
        public Producto Producto { get; set; }
    }
}
