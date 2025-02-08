namespace FerreteriaAPI.Models
{
    public class Cuenta
    {
        public int Id_Cuenta { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }

        // Llave foránea para la relación uno a uno con Administrador
        public int AdministradorId { get; set; }
        public Administrador Administrador { get; set; }


        // Llave foránea para la relación uno a muchos con Rol
        public int RolId { get; set; }
        public Rol Rol { get; set; }

        // Llave foránea para la relación uno a uno con RegistroCliente
        public int RegistroClienteId { get; set; }
        public RegistroCliente RegistroCliente { get; set; }
    }
}
