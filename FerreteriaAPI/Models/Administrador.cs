namespace FerreteriaAPI.Models
{
    public class Administrador
    {
        public int Id_administrador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }

        // Relación uno a uno con Cuenta
        public Cuenta Cuenta { get; set; }
    }
}
