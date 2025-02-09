using FerreteriaKialkeWEB.Modelado;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace FerreteriaKialkeWEB.Datos
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
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<EntradaProducto> EntradaProductos { get; set; }
        public DbSet<SalidaProducto> SalidasProductos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleFactura>()
                .HasKey(pc => new { pc.Id_Factura, pc.Id_Producto });

            modelBuilder.Entity<DetalleFactura>()
                .HasOne(p => p.Factura)
                .WithMany(pc => pc.DetalleFacturas)
                .HasForeignKey(p => p.Id_Factura);

            modelBuilder.Entity<DetalleFactura>()
                .HasOne(p => p.Producto)
                .WithMany(pc => pc.DetalleFacturas)
                .HasForeignKey(p => p.Id_Producto);




        }


    }
}
