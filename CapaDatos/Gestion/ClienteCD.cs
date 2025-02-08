using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadCliente = CapaEntidades.Gestion.Cliente;

namespace CapaDatos.Gestion
{
    public class ClienteCD
    {
        public static List<CP_ListarClientesResult> listarClientesCD()
        {
            ConexionDataContext conectorBD = null;   //declaramos
            List<CP_ListarClientesResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext(); //intsancionamos la conexion
                lista = conectorBD.CP_ListarClientes().ToList();    //de la conexionBD ejecutamos el proc almc
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al listar ClientesCD" + error.Message);
            }
            return lista;
        }

        public static List<CP_FiltrarClientesResult> filtrarClientesCD(string clave)
        {
            ConexionDataContext conectorBD = null;
            List<CP_FiltrarClientesResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.CP_FiltrarClientes(clave).ToList();
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al filtrar ClientesCD" + error.Message);
            }
            return lista;
        }

        public static void insertarClienteCD(EntidadCliente cliente)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_InsertarCliente(cliente.IdCuenta, cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.FechaNacimiento, cliente.Telefono);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al insertar ClientesCD" + error.Message);
            }
        }

        public static void modificarClienteCD(EntidadCliente cliente)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_ModificarCliente(cliente.IdCliente, cliente.IdCuenta, cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.FechaNacimiento, cliente.Telefono);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al modificar ClientesCD" + error.Message);
            }
        }

        public static void eliminarClienteCD(int idCliente)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_EliminarCliente(idCliente);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al eliminar ClientesCD" + error.Message);
            }
        }
    }
}
