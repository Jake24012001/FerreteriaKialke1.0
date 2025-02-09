namespace FerreteriaKialkeWEB.Modelado
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }

        public int Id_Cuenta { get; set; }
        public Cuenta Cuenta { get; set; }



    }
}
