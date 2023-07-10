using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public Marca oId_Marca { get; set; }
        public Categoria oId_Categoria { get; set; }
        public decimal Precio { get; set; } = 0;
        public int Inventario { get; set; }
        public string Ruta_Imagen { get; set; }
        public string Nombre_Imagen { get; set; }
        public bool Activo { get; set; } = true;
    }

}
