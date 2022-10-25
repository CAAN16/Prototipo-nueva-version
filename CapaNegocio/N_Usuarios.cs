using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocio
{
    public class N_Usuarios
    {
        private D_Usuarios obj_D_Usuario = new D_Usuarios();

        public List<Usuarios> ListandoUsuarios()
        {
            return obj_D_Usuario.ListarUsuarios();
        }

        public int RegistrandoUusario(Usuarios usuario)
        {
            return obj_D_Usuario.RegistrarUsuario(usuario);
        }

        public bool UsuarioExiste(string usuario, string correo)
        {
            return obj_D_Usuario.UsuarioExiste(usuario, correo);
        }

        public string generarSha1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
