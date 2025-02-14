using FerreteriaKialkeWEB.Datos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FerreteriaKialkeWEB.Modelado;
using FerreteriaPAweb.Models;

namespace FerreteriaKialkeWEB.Controladores

{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteCTR : ControllerBase
    {
        private readonly FerreteriaPaBacpacContext context;

        public ClienteCTR(FerreteriaPaBacpacContext _dbcontxt)
        {
            context = _dbcontxt;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            List<Cliente> listCliente = new List<Cliente>();
            try
            {
                listCliente  = context.Clientes.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", respuesta = listCliente });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, respuesta = listCliente });
            }
        }





    }
}
