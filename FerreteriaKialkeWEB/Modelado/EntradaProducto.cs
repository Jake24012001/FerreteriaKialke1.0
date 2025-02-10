using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class EntradaProducto
{
    public int IdEntradaProducto { get; set; }

    public int IdProducto { get; set; }

    public int IdProveedor { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public int Cantidad { get; set; }

    public decimal CostoUnitario { get; set; }

    public string? Observacion { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
