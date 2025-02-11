using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class SalidaProducto
    {
        private int idSalidaProducto;
        private int idProducto;
        private DateTime fechaSalida;
        private int cantidad;
        private string motivo;
        private string observacion;

        public SalidaProducto()
        {

        }

        public SalidaProducto(int idSalidaProducto, int idProducto, DateTime fechaSalida, int cantidad, string motivo, string observacion)
        {
            this.idSalidaProducto = idSalidaProducto;
            this.idProducto = idProducto;
            this.fechaSalida = fechaSalida;
            this.cantidad = cantidad;
            this.motivo = motivo;
            this.observacion = observacion;
        }

        public SalidaProducto(int idProducto, DateTime fechaSalida, int cantidad, string motivo, string observacion)
        {
            this.idProducto = idProducto;
            this.fechaSalida = fechaSalida;
            this.cantidad = cantidad;
            this.motivo = motivo;
            this.observacion = observacion;
        }

        public int IdSalidaProducto { get => idSalidaProducto; set => idSalidaProducto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Observacion { get => observacion; set => observacion = value; }


    }
}
