using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class D_Usuarios
    {
        public List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> list = new List<Usuarios>();
            using (SqlConnection connection = new SqlConnection(Conexion.Nombre_Conexion))
            {
                SqlCommand command = new SqlCommand("SP_ListarUsuarios", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader LeerFilas = command.ExecuteReader())
                {
                    while (LeerFilas.Read())
                    {
                        list.Add(new Usuarios()
                        {
                            id_usuario = Convert.ToInt32(LeerFilas["id_usuario"]),
                            nombre = LeerFilas["nombre"].ToString(),
                            usuario = LeerFilas["usuario"].ToString(),
                            correo = LeerFilas["correo"].ToString(),
                            pasword = LeerFilas["pasword"].ToString()
                        });
                    }
                }
                return list;
            }
        }

        public int RegistrarUsuario(Usuarios usuario)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Nombre_Conexion))
            {
                SqlCommand command = new SqlCommand("SP_RegistrarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                command.Parameters.AddWithValue("nombre", usuario.nombre);
                command.Parameters.AddWithValue("usuario", usuario.usuario);
                command.Parameters.AddWithValue("correo", usuario.correo);
                command.Parameters.AddWithValue("pasword", usuario.pasword);
                command.Parameters.Add("idusuariogenerado", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                int idusuariogenerado = Convert.ToInt32(command.Parameters["idusuariogenerado"].Value);
                return idusuariogenerado;

            }
        }

        public bool UsuarioExiste(string usuario, string correo)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Nombre_Conexion))
            {
                SqlDataReader reader;
                SqlCommand command = new SqlCommand("SP_UsuarioExiste", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                command.Parameters.AddWithValue("usuario", usuario);
                command.Parameters.AddWithValue("correo", correo);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
