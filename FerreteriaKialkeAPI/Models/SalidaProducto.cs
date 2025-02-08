namespace FerreteriaKialkeAPI.Models
{
    public class SalidaProducto
    {
        private int Id_SalidaProducto { get; set; }
        private int Id_Producto { get; set; }
        private int Cantidad { get; set; }
        private DateTime FechaSalida { get; set; }
        private string Motivo { get; set; }
        private string Observacion
        {
            get; set;
        }

        public SalidaProducto(int id_SalidaProducto, int id_Producto, int cantidad, DateTime fechaSalida, string motivo, string observacion)
        {
            Id_SalidaProducto = id_SalidaProducto;
            Id_Producto = id_Producto;
            Cantidad = cantidad;
            FechaSalida = fechaSalida;
            Motivo = motivo;
            Observacion = observacion;
        }
    }
}
