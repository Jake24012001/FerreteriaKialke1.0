using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class Factura
    {
        private int Id_Factura { get; set; }
        private int Id_Cliente { get; set; }
        private DateTime FechaEmision { get; set; }
        private string MetodoPago { get; set; }
        private decimal Total { get; set; }
        private int Iva { get; set; }

        public Factura(int id_Factura, int id_Cliente, DateTime fechaEmision, string metodoPago, decimal total, int iva)
        {
            Id_Factura = id_Factura;
            Id_Cliente = id_Cliente;
            FechaEmision = fechaEmision;
            MetodoPago = metodoPago;
            Total = total;
            Iva = iva;
        }
    }
}
