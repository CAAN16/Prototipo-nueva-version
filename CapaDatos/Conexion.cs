using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string Nombre_Conexion = ConfigurationManager.ConnectionStrings["connect"].ToString();
    }
}
