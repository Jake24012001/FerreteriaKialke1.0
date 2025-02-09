namespace FerreteriaKialkeWEB.Modelado
{
    public class Cuenta
    {
        public int Id_Cuenta { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public int Id_rol { get; set; }
        public Rol Rol { get; set; }

    }
}
