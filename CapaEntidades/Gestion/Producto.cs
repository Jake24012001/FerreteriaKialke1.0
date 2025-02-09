using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Producto
    {
        private int idProducto;
        private int idCategoriaProducto;
        private string nombre;
        private decimal precio;
        private int stock;
        private string estado;
        private string icono;
        private string descripcion;

        public Producto()
        {

        }

        public Producto(int idProducto, int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            this.idProducto = idProducto;
            this.idCategoriaProducto = idCategoriaProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.estado = estado;
            this.icono = icono;
            this.descripcion = descripcion;
        }

        public Producto(int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            this.idCategoriaProducto = idCategoriaProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.estado = estado;
            this.icono = icono;
            this.descripcion = descripcion;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCategoriaProducto { get => idCategoriaProducto; set => idCategoriaProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Icono { get => icono; set => icono = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        
    }
}
