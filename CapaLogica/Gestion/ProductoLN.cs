using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Producto = CapaEntidades.Gestion.Producto;
using ProductoCD = CapaDatos.Gestion.ProductoCD;

namespace CapaLogica.Gestion
{
    public class ProductoLN
    {

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

        public static List<Producto> filtrarVistaProductosLN()
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
    }
}
