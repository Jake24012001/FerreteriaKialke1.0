namespace FerreteriaKialkeAPI.Models
{
    public class Cuenta
    {
        public int Id_Cuenta { get; set; }
        public int Id_rol { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public Cuenta(int id_Cuenta, int id_rol, string mail, string password)
        {
            Id_Cuenta = id_Cuenta;
            Id_rol = id_rol;
            Mail = mail;
            Password = password;
        }
    }
}
