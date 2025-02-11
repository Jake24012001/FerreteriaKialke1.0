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


        [HttpGet]
        [Route("Obtener")]
        public IActionResult Obtener(int idCuenta)
        {
            Cuenta oCuenta = context.Cuenta.Find(idCuenta);
            if (oCuenta == null)
            {
                return BadRequest("Cuenta no encontrado");
            }
            try
            {
                oCuenta = context.Cuenta.Where(p => p.IdCuenta == idCuenta).FirstOrDefault();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Cuenta", respuesta = oCuenta });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, respuesta = oCuenta });
            }
        }
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Cuenta objeto)
        {
            try
            {
                context.Cuenta.Add(objeto);
                context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Cuenta" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] Cuenta objeto)
        {
            Cuenta oCuenta = context.Cuenta.Find(objeto.IdCuenta);
            if (oCuenta == null)
            {
                return BadRequest("Cuenta no encontrado");
            }
            try
            {
                oCuenta.Mail = objeto.Mail is null ? oCuenta.Mail : objeto.Mail;
                oCuenta.Password = objeto.Password is null ? oCuenta.Password : objeto.Password;


                context.Cuenta.Add(objeto);
                context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Cuenta" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }


        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult Eliminar(int idCuenta)
        {
            Cuenta oCuenta = context.Cuenta.Find(idCuenta);
            if (oCuenta == null)
            {
                return BadRequest("Rol no encontrado");
            }
            try
            {

                context.Cuenta.Remove(oCuenta);
                context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Cuenta" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }
    }
}
