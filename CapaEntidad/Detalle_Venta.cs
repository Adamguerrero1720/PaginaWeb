using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int Id_DetalleVenta { get; set; }
        public int Id_Venta { get; set; }
        public Producto oId_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string Id_Transaccion { get; set; }
    }

}
