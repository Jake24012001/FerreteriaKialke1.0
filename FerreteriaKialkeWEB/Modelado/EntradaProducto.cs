namespace FerreteriaKialkeWEB.Modelado
{
    public class EntradaProducto
    {
        public int Id_EntradaProducto { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Proveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public string Observacion { get; set; }


        public Producto Producto { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
