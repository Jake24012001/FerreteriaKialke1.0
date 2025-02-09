using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadProducto = CapaEntidades.Gestion.Producto;


namespace CapaDatos.Gestion
{
    public class ProductoCD
    {
        public static List<FiltrarVistaProductoCategoriaResult> filtrarVistaProductosCD(string clave)
        {
            ConexionDataContext conectorBD = null;
            List<FiltrarVistaProductoCategoriaResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.FiltrarVistaProductoCategoria(clave).ToList();
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en listar Vista Productos CD" + error.Message);
            }
            return lista;
        }


        public static List<CP_ListarProductosResult> listarProductosCD()
        {
            ConexionDataContext conectorBD = null;
            List<CP_ListarProductosResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.CP_ListarProductos().ToList();
                conectorBD.SubmitChanges();
            }
            catch(Exception error)
            {
                Console.WriteLine("Error en listar Productos CD" + error.Message);
            }
            return lista;
        }

        public static List<CP_FiltrarProductosResult> filtrarProductosCD(string clave)
        {
            ConexionDataContext conectorBD = null;
            List<CP_FiltrarProductosResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.CP_FiltrarProductos(clave).ToList();
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en filtrar Productos CD" + error.Message);
            }
            return lista;
        }

        public static void insertarProductosCD(EntidadProducto producto)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_InsertarProducto(producto.IdCategoriaProducto, producto.Nombre, producto.Precio, producto.Stock, producto.Estado, producto.Icono, producto.Descripcion);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en insertar Productos CD" + error.Message);
            }
        }

        public static void modificarProductosCD(EntidadProducto producto)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_ModificarProducto(producto.IdProducto, producto.IdCategoriaProducto, producto.Nombre, producto.Precio, producto.Stock, producto.Estado, producto.Icono, producto.Descripcion);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en modificar Productos CD" + error.Message);
            }
        }

        public static void eliminarProductosCD(int idProducto)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_EliminarProducto(idProducto);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en eliminar Productos CD" + error.Message);
            }
        }
    }
}
