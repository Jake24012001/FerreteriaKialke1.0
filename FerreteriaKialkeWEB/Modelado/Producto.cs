using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public int IdCategoriaProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual ICollection<EntradaProducto> EntradaProductos { get; set; } = new List<EntradaProducto>();

    public virtual CategoriaProducto IdCategoriaProductoNavigation { get; set; } = null!;

    public virtual ICollection<SalidaProducto> SalidaProductos { get; set; } = new List<SalidaProducto>();
}
