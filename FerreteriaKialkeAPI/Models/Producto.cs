namespace FerreteriaKialkeAPI.Models
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        
    }
}
