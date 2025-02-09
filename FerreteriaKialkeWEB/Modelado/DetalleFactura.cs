namespace FerreteriaKialkeWEB.Modelado
{
    public class DetalleFactura
    {
        public int Id_DetalleFactura { get; set; }
        public int Id_Factura { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }
        public double Descuentos { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
    }
}
