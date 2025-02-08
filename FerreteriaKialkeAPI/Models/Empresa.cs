namespace FerreteriaKialkeAPI.Models
{
    public class Empresa
    {
        private int Id_Empresa { get; set; }
        private string Nombre { get; set; }
        private string Ruc { get; set; }
        private string Direccion { get; set; }
        private string Representante { get; set; }
        private string Telefono { get; set; }
        private string Mail { get; set; }
        private string Descripcion { get; set; }
        private string Observacion { get; set; }

        public Empresa(int id_Empresa, string nombre, string ruc, string direccion, string representante, string telefono, string mail, string descripcion, string observacion)
        {
            Id_Empresa = id_Empresa;
            Nombre = nombre;
            Ruc = ruc;
            Direccion = direccion;
            Representante = representante;
            Telefono = telefono;
            Mail = mail;
            Descripcion = descripcion;
            Observacion = observacion;
        }
    }
}
