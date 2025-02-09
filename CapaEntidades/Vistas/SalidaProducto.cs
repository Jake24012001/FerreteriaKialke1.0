using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    public class SalidaProducto
    {
        private int id;
        private string categoria;
        private string producto;
        private DateTime fechaSalida;
        private int cantidad;
        private string motivo;
        private string observacion;


        public SalidaProducto()
        {

        }

        public SalidaProducto(int id, string categoria, string producto, DateTime fechaSalida, int cantidad, string motivo, string observacion)
        {
            this.id = id;
            this.categoria = categoria;
            this.producto = producto;
            this.fechaSalida = fechaSalida;
            this.cantidad = cantidad;
            this.motivo = motivo;
            this.observacion = observacion;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Producto { get => producto; set => producto = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
