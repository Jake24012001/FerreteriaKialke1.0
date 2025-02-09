namespace FerreteriaKialkeWEB.Modelado
{
    public class Proveedor
    {
        public int Id_Proveedor { get; set; }
        public int Id_Empresa { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Observacion { get; set; }

        public Empresa Empresa { get; set; }

    }
}
