using System;
using System.Collections.Generic;

namespace FerreteriaPAweb.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ruc { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Representante { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Observacion { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
