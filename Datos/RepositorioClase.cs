using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioClase : IRepositorioClase
    {
        private readonly ContextoDatos contexto;

        public RepositorioClase()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarClase(Clase clase)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Clases SET Nombre = @Nombre, Horario = @Horario, " +
                    "IdEntrenador = @IdEntrenador, IdGimnasio = @IdGimnasio WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", clase.Id);
                cmd.Parameters.AddWithValue("@Nombre", clase.Nombre);
                cmd.Parameters.AddWithValue("@Horario", clase.Horario);
                cmd.Parameters.AddWithValue("@IdEntrenador", clase.IdEntrenador);
                cmd.Parameters.AddWithValue("@IdGimnasio", clase.IdGimnasio);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarClase(Clase clase)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Clases (Nombre, Horario, IdEntrenador, IdGimnasio) " +
                    "VALUES (@Nombre, @Horario, @IdEntrenador, @IdGimnasio)", conn);
                cmd.Parameters.AddWithValue("@Nombre", clase.Nombre);
                cmd.Parameters.AddWithValue("@Horario", clase.Horario);
                cmd.Parameters.AddWithValue("@IdEntrenador", clase.IdEntrenador);
                cmd.Parameters.AddWithValue("@IdGimnasio", clase.IdGimnasio);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarClase(int idClase)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Clases WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idClase);
                cmd.ExecuteNonQuery();
            }
        }

        public Clase ObtenerClase(int idClase)
        {
            Clase clase = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Clases WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idClase);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        clase = new Clase
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Horario = reader.GetDateTime(2),
                            IdEntrenador = reader.GetInt32(3)
                        };
                    }
                }
            }

            return clase;
        }

        public IEnumerable<Clase> ObtenerClases()
        {
            List<Clase> clases = new List<Clase>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT c.Id, c.Nombre, c.Horario, c.IdEntrenador, c.IdGimnasio, e.Nombre, g.Nombre
                FROM Clases c
                INNER JOIN Entrenadores e ON c.IdEntrenador = e.Id
                INNER JOIN Gimnasios g ON c.IdGimnasio = g.Id", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        clases.Add(new Clase
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Horario = reader.GetDateTime(2),
                            IdEntrenador = reader.GetInt32(3),
                            IdGimnasio = reader.GetInt32(4),

                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(5),
                            },
                            GimnasioR = new Gimnasio
                            {
                                Id = reader.GetInt32(4),
                                Nombre = reader.GetString(6),
                            }
                        });
                    }
                }
            }

            return clases;
        }
    }
}
