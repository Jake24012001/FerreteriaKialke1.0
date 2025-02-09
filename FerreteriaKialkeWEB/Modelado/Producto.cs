namespace FerreteriaKialkeWEB.Modelado
{
    public class Producto
    {
        public int Id_Produto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Id_CategoriaProducto { get; set; }
        public CategoriaProducto Categoria { get; set; }
        public ICollection<DetalleFactura> DetalleFacturas { get; set; }

    }
}
