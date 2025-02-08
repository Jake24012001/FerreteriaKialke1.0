using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaMovil.Models
{
    public class EntradaProducto
    {
        private int Id_EntradaProducto { get; set; }
        private int Id_Producto { get; set; }
        private int Id_Proveedor { get; set; }
        private DateTime FechaIngreso { get; set; }
        private int Cantidad { get; set; }
        private decimal CostoUnitario { get; set; }
        private string Observacion { get; set; }

        public EntradaProducto(int id_EntradaProducto, int id_Producto, int id_Proveedor, DateTime fechaIngreso, int cantidad, decimal costoUnitario, string observacion)
        {
            Id_EntradaProducto = id_EntradaProducto;
            Id_Producto = id_Producto;
            Id_Proveedor = id_Proveedor;
            FechaIngreso = fechaIngreso;
            Cantidad = cantidad;
            CostoUnitario = costoUnitario;
            Observacion = observacion;
        }
    }
}
