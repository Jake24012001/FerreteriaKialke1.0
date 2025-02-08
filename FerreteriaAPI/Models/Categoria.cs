namespace FerreteriaAPI.Models
{
    public class Categoria
    {
        private int id_Cate;
        private string nombre;
        private string descripcion;

        public int Id_Cate { get => id_Cate; set => id_Cate = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public ICollection<Producto> productos { get; set; }
        public Categoria(int id_Cate, string nombre, string descripcion)
        {
            Id_Cate = id_Cate;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }



    }
}
