using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadCuenta = CapaEntidades.Gestion.Cuenta;

namespace CapaDatos.Seguridad
{
    public class CuentaCD
    {

        public static List<CP_FiltrarCuentasResult> filtrarVistaCuentaCD(EntidadCuenta cuenta)
        {
            ConexionDataContext conectorBD = null;
            List<CP_FiltrarCuentasResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.CP_FiltrarCuentas(cuenta.Mail, cuenta.Password).ToList();
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al listar CuentaCD" + error.Message);
            }
            return lista;
        }


        public static List<CP_FiltrarCuentasResult> obtenerCuentaCD(EntidadCuenta cuenta)
        {
            ConexionDataContext conectorBD = null; 
            List<CP_FiltrarCuentasResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.CP_FiltrarCuentas(cuenta.Mail, cuenta.Password).ToList();    
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al listar CuentaCD" + error.Message);
            }
            return lista;
        }


        public static void insertarCuentaCD(EntidadCuenta cuenta)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_InsertarCuenta(cuenta.IdRol, cuenta.Mail, cuenta.Password);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al crear cuentaCD" + error.Message);
            }
        }

        public static void modificarCuentaCD(EntidadCuenta cuenta)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_ModificarCuenta(cuenta.IdCuenta, cuenta.IdRol, cuenta.Mail, cuenta.Password);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al modificar cuentaCD" + error.Message);
            }
        }

        public static void eliminarCuentaCD(int idCuenta)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_EliminarCuenta(idCuenta);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al eliminar cuentaCD" + error.Message);
            }
        }
    }
}
