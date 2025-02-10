using FerreteriaPAweb.Models;

namespace FerreteriaKialkeWEB.Modelado
{
    public class Rol
    {
        public int IdRol { get; set; }

        public string Nombre { get; set; } = null!;

        public virtual ICollection<Cuenta> Cuenta { get; set; } = new List<Cuenta>();
    }
}
