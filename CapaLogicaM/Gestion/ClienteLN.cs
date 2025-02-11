using Cliente = CapaEntidades.Gestion.Cliente;
using ClienteCD = CapaDatos.Gestion.ClienteCD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class ClienteLN
    {
        public static List<Cliente> listarClienteLN()
        {
            List<Cliente> lista = null;
            try
            {
                Console.WriteLine("Valio Todo");  
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al lista ClienteLN" + error.Message);
            }
            return lista;
        }
    }
}
