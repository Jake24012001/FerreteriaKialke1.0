using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? Observacion { get; set; }

    public virtual ICollection<EntradaProducto> EntradaProductos { get; set; } = new List<EntradaProducto>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
