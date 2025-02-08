using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class Producto
    {
        private int Id_Producto { get; set; }
        private int Id_CategoriaProducto { get; set; }
        private string Nombre { get; set; }
        private decimal Precio { get; set; }
        private int Stock { get; set; }
        private string Descripcion { get; set; }

        public Producto(int id_Producto, int id_CategoriaProducto, string nombre, decimal precio, int stock, string descripcion)
        {
            Id_Producto = id_Producto;
            Id_CategoriaProducto = id_CategoriaProducto;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Descripcion = descripcion;
        }
    }
}
