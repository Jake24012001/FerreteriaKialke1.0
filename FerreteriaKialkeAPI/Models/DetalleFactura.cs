namespace FerreteriaKialkeAPI.Models
{
    public class DetalleFactura
    {
        private int Id_DetalleFactura { get; set; }
        private int Id_Producto { get; set; }
        private int Id_Factura { get; set; }
        private int Cantidad { get; set; }
        private decimal Subtotal { get; set; }

        public DetalleFactura(int id_DetalleFactura, int id_Producto, int id_Factura, int cantidad, decimal subtotal)
        {
            Id_DetalleFactura = id_DetalleFactura;
            Id_Producto = id_Producto;
            Id_Factura = id_Factura;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}
