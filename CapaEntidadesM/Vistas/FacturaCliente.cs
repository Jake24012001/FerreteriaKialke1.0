using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    public class FacturaCliente
    {
        private int numFactura;
        private string cliente;
        private string mail;
        private DateTime fechaEmision;
        private string metodoPago;
        private int iva;
        private decimal total;

        public FacturaCliente()
        {

        }
        public FacturaCliente(int numFactura, string cliente, string mail, DateTime fechaEmision, string metodoPago, int iva, decimal total)
        {
            this.numFactura = numFactura;
            this.cliente = cliente;
            this.mail = mail;
            this.fechaEmision = fechaEmision;
            this.metodoPago = metodoPago;
            this.iva = iva;
            this.total = total;
        }

        public int NumFactura { get => numFactura; set => numFactura = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Mail { get => mail; set => mail = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public int Iva { get => iva; set => iva = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
