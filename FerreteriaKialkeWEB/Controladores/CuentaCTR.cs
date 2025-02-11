using FerreteriaKialkeWEB.Datos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FerreteriaKialkeWEB.Modelado;
using FerreteriaPAweb.Models;
namespace FerreteriaKialkeWEB.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaCTR : ControllerBase
    {
        private readonly FerreteriaPaBacpacContext context;

        public CuentaCTR(FerreteriaPaBacpacContext _dbcontxt)
        {
            context = _dbcontxt;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            List<Cuenta> listCuenta = new List<Cuenta>();
            try
            {
                listCuenta = context.Cuenta.ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", respuesta = listCuenta });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, respuesta = listCuenta });
            }
        }


    }
}
