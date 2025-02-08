namespace FerreteriaAPI.Models
{
    public class Producto
    {
        public int Id_Produto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Id_Cate { get; set; }
        public Categoria Categoria { get; set; }
        public int Id_Proveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public ICollection<DetalleFactura> Detalles { get; set; }
    }
}
