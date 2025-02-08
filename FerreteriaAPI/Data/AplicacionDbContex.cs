using Microsoft.EntityFrameworkCore;
using FerreteriaAPI.Models;

namespace FerreteriaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<RegistroCliente> RegistrosClientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar la llave compuesta de DetalleFactura
            modelBuilder.Entity<DetalleFactura>()
                .HasKey(df => new { df.Id_Factura, df.Id_Producto });

            // Relación muchos a uno entre DetalleFactura y Factura
            modelBuilder.Entity<DetalleFactura>()
                .HasOne(df => df.Factura)
                .WithMany(f => f.Detalle)
                .HasForeignKey(df => df.Factura);

            // Relación muchos a uno entre DetalleFactura y Producto
            modelBuilder.Entity<DetalleFactura>()
                .HasOne(df => df.Producto)
                .WithMany(p => p.Detalles)
                .HasForeignKey(df => df.Id_Producto);

            // Relación muchos a uno entre Producto y Proveedor
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Proveedor)
                .WithMany(pr => pr.Productos)
                .HasForeignKey(p => p.Id_Proveedor);

            // Relación uno a uno entre RegistroCliente y Cuenta
            modelBuilder.Entity<RegistroCliente>()
                .HasOne(rc => rc.Cuenta)
                .WithOne(c => c.RegistroCliente)
                .HasForeignKey<Cuenta>(c => c.RegistroClienteId);

            // Relación uno a muchos entre RegistroCliente y Factura
            modelBuilder.Entity<Factura>()
                .HasOne(f => f.RegistroCliente)
                .WithMany(rc => rc.Facturas)
                .HasForeignKey(f => f.RegistroClienteId);

            // Relación uno a uno entre Cuenta y Administrador
            modelBuilder.Entity<Administrador>()
                .HasOne(a => a.Cuenta)
                .WithOne(c => c.Administrador)
                .HasForeignKey<Cuenta>(c => c.AdministradorId);

            // Relación uno a muchos entre Rol y Cuenta
            modelBuilder.Entity<Cuenta>()
                .HasOne(c => c.Rol)
                .WithMany(r => r.Cuentas)
                .HasForeignKey(c => c.RolId);
        }
    }
}
