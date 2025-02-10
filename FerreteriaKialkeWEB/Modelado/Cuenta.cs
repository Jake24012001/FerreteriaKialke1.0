using System;
using System.Collections.Generic;
using FerreteriaKialkeWEB.Modelado;
using FerreteriaPAweb.Models;

namespace FerreteriaPAweb.Models;

public partial class Cuenta
{
    public int IdCuenta { get; set; }

    public int IdRol { get; set; }

    public string Mail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Rol  IdRolNavigation { get; set; } = null!;
}
