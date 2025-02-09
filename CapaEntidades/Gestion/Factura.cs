using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Factura
    {
        private int idFactura;
        private int idCliente;
        private DateTime fechaEmision;
        private string metodoPago;
        private decimal total;
        private int iva;

        public Factura()
        {

        }

        public Factura(int idFactura, int idCliente, DateTime fechaEmision, string metodoPago, decimal total, int iva)
        {
            this.idFactura = idFactura;
            this.idCliente = idCliente;
            this.fechaEmision = fechaEmision;
            this.metodoPago = metodoPago;
            this.total = total;
            this.iva = iva;
        }

        public Factura(int idCliente, DateTime fechaEmision, string metodoPago, decimal total, int iva)
        {
            this.idCliente = idCliente;
            this.fechaEmision = fechaEmision;
            this.metodoPago = metodoPago;
            this.total = total;
            this.iva = iva;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public decimal Total { get => total; set => total = value; }
        public int Iva { get => iva; set => iva = value; }
    }
}
