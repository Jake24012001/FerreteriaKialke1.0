using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Producto = CapaEntidades.Gestion.Producto;
using ProductoCD = CapaDatos.Gestion.ProductoCD;
using ProductoCategoria = CapaEntidades.Vistas.ProductoCategoria;

namespace CapaLogica.Gestion
{
    public class ProductoLN
    {
        public static List<ProductoCategoria> filtrarVistaProductosLN(string clave)
        {
            List<ProductoCategoria> lista = null;
            try
            {
                var sql = from x in ProductoCD.filtrarVistaProductosCD(clave)
                          select new ProductoCategoria(x.ID, x.Categoria, x.Producto, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en filtrar Vista Productos LN" + error.Message);
            }
            return lista;
        }

        public static List<Producto> listarProductosLN()
        {
            List<Producto> lista = null;   
            try
            {
                var sql = from x in ProductoCD.listarProductosCD()
                          select new Producto(x.Id_Producto, x.Id_CategoriaProducto, x.Nombre, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en listar Productos LN" + error.Message);
            }
            return lista;
        }

        public static List<Producto> filtrarProductosLN(string clave)
        {
            List<Producto> lista = null;
            try
            {
                var sql = from x in ProductoCD.filtrarProductosCD(clave)
                          select new Producto(x.Id_Producto, x.Id_CategoriaProducto, x.Nombre, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en filtrar Productos LN" + error.Message);
            }
            return lista;
        }

        public static void insertarProductoLN(Producto producto)
        {
            try
            {
                ProductoCD.insertarProductosCD(producto);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en insertar Productos LN" + error.Message);
            }
        }

        public static void modificarProductoLN(Producto producto)
        {
            try
            {
                ProductoCD.modificarProductosCD(producto);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en modificar Productos LN" + error.Message);
            }
        }

        public static void eliminarProductoLN(int idProducto)
        {
            try
            {
                ProductoCD.eliminarProductosCD(idProducto);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en eliminar Productos LN" + error.Message);
            }
        }


    }
}
