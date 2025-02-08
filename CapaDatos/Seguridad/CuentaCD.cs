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
        public static List<CP_FiltrarCuentasResult> getCuentaCD(string mail, string passwd)
        {
            ConexionDataContext conectorBD = null; 
            List<CP_FiltrarCuentasResult> lista = null;
            try
            {
                conectorBD = new ConexionDataContext();
                lista = conectorBD.CP_FiltrarCuentas(mail, passwd).ToList();    //de la conexionBD ejecutamos el proc almc
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al getCuentaCD" + error.Message);
            }
            return lista;
        }


        public static void crearCuentaCD(EntidadCuenta cuenta)
        {
            ConexionDataContext conectorBD = null;
            try
            {
                conectorBD = new ConexionDataContext();
                conectorBD.CP_InsertarCuenta(cuenta.Id_rol, cuenta.Mail, cuenta.Password);
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
                conectorBD.CP_ModificarCuenta(cuenta.Id_Cuenta, cuenta.Id_rol, cuenta.Mail, cuenta.Password);
                conectorBD.SubmitChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al modificar cuentaCD" + error.Message);
            }
        }
    }
}
