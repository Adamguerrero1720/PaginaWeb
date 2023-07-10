using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public bool Reestablecer { get; set; } = false;
        public bool Activo { get; set; } = true;
    }

}
