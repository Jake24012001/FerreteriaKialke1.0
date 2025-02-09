using FerreteriaKialkeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore;
using FerreteriaKialkeAPI.Datos;
using System.Data;
namespace FerreteriaKialkeAPI.Controlador
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly string cadenaSQL;

        public ProductoController(IConfiguration conf)
        {
            cadenaSQL = conf.GetConnectionString("DefaultConnection");
        }


        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("CP_ListarProductos", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            lista.Add(new Producto()
                            {
                                Id_Producto = Convert.ToInt32(rd["Id_Producto"]),
                                Id_Categoria = Convert.ToInt32(rd["Id_Cate"]),
                                Stock = Convert.ToInt32(rd["Stock"]),
                                Nombre = rd["Nombre"].ToString(),
                                Precio = Convert.ToDecimal(rd["Precio"]),
                                Descripcion = rd["Descripcion"].ToString()




                            });
                        }
                    }
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", reponde = lista });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, reponde = lista });
            }
        }
    }
}
