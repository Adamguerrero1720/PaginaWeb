using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select Id_Usuario, Nombre_Usuario, Apellido_Usuario, Correo, Contraseña, Reestablecer, Activo from Usuarios";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(
                                new Usuarios()
                                {
                                    Id_Usuario = Convert.ToInt32(rdr["Id_Usuario"]),
                                    Nombre_Usuario = rdr["Nombre_Usuario"].ToString(),
                                    Apellido_Usuario = rdr["Apellido_Usuario"].ToString(),
                                    Correo = rdr["Correo"].ToString(),
                                    Contraseña = rdr["Contraseña"].ToString(),
                                    Reestablecer = Convert.ToBoolean(rdr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(rdr["Activo"])
                                }); ;
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Usuarios>();
            }
            return lista;
        }
    }
}
