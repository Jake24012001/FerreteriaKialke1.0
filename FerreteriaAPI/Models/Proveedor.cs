namespace FerreteriaAPI.Models
{
    public class Proveedor
    {
        public int Id_Proveedor { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Representante { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        public ICollection<Producto> Productos { get; set; }

        public Proveedor(int id_Proveedor, string ruc, string nombre, string representante, string direccion, string telefono, string mail, ICollection<Producto> productos)
        {
            Id_Proveedor = id_Proveedor;
            Ruc = ruc;
            Nombre = nombre;
            Representante = representante;
            Direccion = direccion;
            Telefono = telefono;
            Mail = mail;
            Productos = productos;
        }
    }
}
