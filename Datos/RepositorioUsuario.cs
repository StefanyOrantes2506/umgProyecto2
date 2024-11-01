using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly ContextoDatos contexto;

        public RepositorioUsuario()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET NombreUsuario = @NombreUsuario, Contrasenia = @Contrasenia " +
                    "WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (NombreUsuario, Contrasenia) " +
                    "VALUES (@NombreUsuario, @Contrasenia)", conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            Usuario usuario = null;

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE NombreUsuario = @NombreUsuario", conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        usuario = new Usuario
                        {
                            NombreUsuario = reader.GetString(1),
                            Contrasenia = reader.GetString(2)
                        };
                    }
                }

                conn.Close();
            }
            return usuario;
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new Usuario
                        {
                            Id = reader.GetInt32(0),
                            NombreUsuario = reader.GetString(1),
                            Contrasenia = reader.GetString(2),
                        });
                    }
                }
            }

            return usuarios;
        }
    }
}
