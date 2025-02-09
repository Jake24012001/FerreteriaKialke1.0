using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class DetalleFactura
    {
        private int idDetalleFactura;
        private int idProducto;
        private int idFactura;
        private int cantidad;
        private decimal subtotal;

        public DetalleFactura()
        {

        }

        public DetalleFactura(int idDetalleFactura, int idProducto, int idFactura, int cantidad, decimal subtotal)
        {
            this.idDetalleFactura = idDetalleFactura;
            this.idProducto = idProducto;
            this.idFactura = idFactura;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public DetalleFactura( int idProducto, int idFactura, int cantidad, decimal subtotal)
        {
            this.idProducto = idProducto;
            this.idFactura = idFactura;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public int IdDetalleFactura { get => idDetalleFactura; set => idDetalleFactura = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
    }
}
