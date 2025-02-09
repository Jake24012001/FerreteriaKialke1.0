namespace FerreteriaKialkeWEB.Modelado
{
    public class SalidaProducto
    {
        public int Id_SalidaProducto { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Motivo { get; set; }
        public string Observacion{get; set; }

        public Producto Producto { get; set; }



    }
}
