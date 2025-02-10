using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public int IdCliente { get; set; }

    public DateOnly FechaEmision { get; set; }

    public string MetodoPago { get; set; } = null!;

    public decimal Total { get; set; }

    public int Iva { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
