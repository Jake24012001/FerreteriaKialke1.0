namespace FerreteriaKialkeAPI.Models
{
    public class Rol
    {
        private int Id_Rol { get; set; }
        private string Nombre { get; set; }

        public Rol(int id_Rol, string nombre)
        {
            Id_Rol = id_Rol;
            Nombre = nombre;
        }
    }
}
