using FerreteriaKialkeAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FerreteriaKialkeAPI.Datos
{
    public class DatosContext : DbContext
    {
        public DatosContext(DbContextOptions<DatosContext> options) : base(options)
        {
        }

        public DbSet<CategoriaProducto> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedore { get; set; }
        public DbSet<Rol> Rols { get; set; }


        
    }
}
