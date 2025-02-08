namespace FerreteriaAPI.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Relación uno a muchos con Cuenta
        public ICollection<Cuenta> Cuentas { get; set; }
    }
}
