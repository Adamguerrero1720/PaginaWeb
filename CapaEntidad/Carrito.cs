using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Carrito
    {
        public int Id_Carrito { get; set; }
        public Cliente oId_Cliente { get; set; }
        public Producto oId_Producto { get; set; }
        public int Cantidad { get; set; }
    }

}
