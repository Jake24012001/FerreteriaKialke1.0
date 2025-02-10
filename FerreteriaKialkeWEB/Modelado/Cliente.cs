using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public int? IdCuenta { get; set; }

    public string Cedula { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Telefono { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cuenta? IdCuentaNavigation { get; set; }
}
