using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FerreteriaKialkeWEB.Datos;
using FerreteriaKialkeWEB.Modelado;

namespace FerreteriaKialkeWEB.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolCTR : ControllerBase
    {
        private readonly FerreteriaPaBacpacContext context;

        public RolCTR(FerreteriaPaBacpacContext _dbcontxt)
        {
            context = _dbcontxt;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            List<Rol> listRol = new List<Rol>();
            try
            {
                listRol = context.Rols.ToList();
                return StatusCode(StatusCodes.Status200OK , new { mensaje = "rol" , respuesta = listRol});

            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, respuesta = listRol });
            }
        }
    }
}
