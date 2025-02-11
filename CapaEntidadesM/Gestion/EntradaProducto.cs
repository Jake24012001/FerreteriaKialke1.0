using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class EntradaProducto
    {
        private int idEntradaProducto;
        private int idProducto;
        private int idProveedor;
        private DateTime fechaIngreso;
        private int cantidad;
        private decimal costoUnitario;
        private decimal costoTotal;
        private string observacion;

        public EntradaProducto()
        {

        }

        public EntradaProducto(int idEntradaProducto, int idProducto, int idProveedor, DateTime fechaIngreso, int cantidad, decimal costoUnitario, decimal costoTotal, string observacion)
        {
            this.idEntradaProducto = idEntradaProducto;
            this.idProducto = idProducto;
            this.idProveedor = idProveedor;
            this.fechaIngreso = fechaIngreso;
            this.cantidad = cantidad;
            this.costoUnitario = costoUnitario;
            this.costoTotal = costoTotal;
            this.observacion = observacion;
        }

        public EntradaProducto(int idProducto, int idProveedor, DateTime fechaIngreso, int cantidad, decimal costoUnitario, decimal costoTotal, string observacion)
        {
            this.idProducto = idProducto;
            this.idProveedor = idProveedor;
            this.fechaIngreso = fechaIngreso;
            this.cantidad = cantidad;
            this.costoUnitario = costoUnitario;
            this.costoTotal = costoTotal;
            this.observacion = observacion;
        }

        public int IdEntradaProducto { get => idEntradaProducto; set => idEntradaProducto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public decimal CostoTotal { get => costoTotal; set => costoTotal = value; }
        public string Observacion { get => observacion; set => observacion = value; }



    }
}
