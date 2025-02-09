using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    public class ProductoCategoria
    {
        private int id;
        private string categoria;
        private string producto;
        private decimal precio;
        private int stock;
        private string estado;
        private string icono;
        private string descripcion;

        public ProductoCategoria()
        {

        }

        public ProductoCategoria(int id, string categoria, string producto, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            this.id = id;
            this.categoria = categoria;
            this.producto = producto;
            this.precio = precio;
            this.stock = stock;
            this.estado = estado;
            this.icono = icono;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Producto { get => producto; set => producto = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Icono { get => icono; set => icono = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}