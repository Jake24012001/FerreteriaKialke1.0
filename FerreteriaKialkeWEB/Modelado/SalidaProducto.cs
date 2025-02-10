using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class SalidaProducto
{
    public int IdSalidaProducto { get; set; }

    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    public DateOnly FechaSalida { get; set; }

    public string Motivo { get; set; } = null!;

    public string? Observacion { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
