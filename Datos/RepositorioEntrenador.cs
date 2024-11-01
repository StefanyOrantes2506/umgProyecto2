using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioEntrenador : IRepositorioEntrenador
    {
        private readonly ContextoDatos contexto;

        public RepositorioEntrenador()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarEntrenador(Entrenador entrenador)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Entrenadores SET Nombre = @Nombre, Apellido = @Apellido, " +
                    "Edad = @Edad WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", entrenador.Id);
                cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entrenador.Apellido);
                cmd.Parameters.AddWithValue("@Edad", entrenador.Edad);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarEntrenador(Entrenador entrenador)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Entrenadores (Nombre, Apellido, Edad) " +
                    "VALUES (@Nombre, @Apellido, @Edad)", conn);
                cmd.Parameters.AddWithValue("@Nombre", entrenador.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entrenador.Apellido);
                cmd.Parameters.AddWithValue("@Edad", entrenador.Edad);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarEntrenador(int idEntrenador)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Entrenadores WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idEntrenador);
                cmd.ExecuteNonQuery();
            }
        }

        public Entrenador ObtenerEntrenador(int idEntrenador)
        {
            Entrenador entrenador = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Entrenadores WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idEntrenador);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        entrenador = new Entrenador
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Edad = reader.GetInt32(3)
                        };
                    }
                }
            }

            return entrenador;
        }

        public IEnumerable<Entrenador> ObtenerEntrenadores()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Entrenadores", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        entrenadores.Add(new Entrenador
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Edad = reader.GetInt32(3)
                        });
                    }
                }
            }

            return entrenadores;
        }
    }
}
