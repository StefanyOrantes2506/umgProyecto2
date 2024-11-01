using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioAsistencia : IRepositorioAsistencia
    {
        private readonly ContextoDatos contexto;

        public RepositorioAsistencia()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarAsistencia(Asistencia asistencia)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Asistencias SET IdMiembro = @IdMiembro, Fecha = @Fecha, " +
                    "IdClase = @IdClase, IdEntrenador = @IdEntrenador WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", asistencia.Id);
                cmd.Parameters.AddWithValue("@IdMiembro", asistencia.IdMiembro);
                cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                cmd.Parameters.AddWithValue("@IdClase", asistencia.IdClase);
                cmd.Parameters.AddWithValue("@IdEntrenador", asistencia.IdEntrenador);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarAsistencia(Asistencia asistencia)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Asistencias (IdMiembro, Fecha, IdClase, IdEntrenador) " +
                    "VALUES (@IdMiembro, @Fecha, @IdClase, @IdEntrenador)", conn);
                cmd.Parameters.AddWithValue("@IdMiembro", asistencia.IdMiembro);
                cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                cmd.Parameters.AddWithValue("@IdClase", asistencia.IdClase);
                cmd.Parameters.AddWithValue("@IdEntrenador", asistencia.IdEntrenador);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAsistencia(int idAsistencia)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Asistencias WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idAsistencia);
                cmd.ExecuteNonQuery();
            }
        }

        public Asistencia ObtenerAsistencia(int idAsistencia)
        {
            Asistencia asistencia = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Asistencias WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idAsistencia);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        asistencia = new Asistencia
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            Fecha = reader.GetDateTime(2),
                            IdClase = reader.GetInt32(3),
                            IdEntrenador = reader.GetInt32(4),
                        };
                    }
                }
            }

            return asistencia;
        }

        public IEnumerable<Asistencia> ObtenerAsistencias()
        {
            List<Asistencia> asistencias = new List<Asistencia>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT a.Id, a.IdMiembro, a.Fecha, a.IdClase, a.IdEntrenador, m.Nombre, c.Nombre, e.Nombre
                FROM Asistencias a
                INNER JOIN Miembros m ON a.IdMiembro = m.Id
                INNER JOIN Clases c ON a.IdClase = c.Id
                INNER JOIN Entrenadores e ON a.IdEntrenador = e.Id", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        asistencias.Add(new Asistencia
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            Fecha = reader.GetDateTime(2),
                            IdClase = reader.GetInt32(3),
                            IdEntrenador = reader.GetInt32(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(4),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return asistencias;
        }

        public IEnumerable<Asistencia> ObtenerAsistenciasPorClase(int idClase)
        {
            List<Asistencia> asistencias = new List<Asistencia>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT a.Id, a.IdMiembro, a.Fecha, a.IdClase, a.IdEntrenador, m.Nombre, c.Nombre, e.Nombre
                FROM Asistencias a
                INNER JOIN Miembros m ON a.IdMiembro = m.Id
                INNER JOIN Clases c ON a.IdClase = c.Id
                INNER JOIN Entrenadores e ON a.IdEntrenador = e.Id 
                WHERE a.IdClase = @IdClase", conn);
                cmd.Parameters.AddWithValue("@IdClase", idClase);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asistencias.Add(new Asistencia
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            Fecha = reader.GetDateTime(2),
                            IdClase = reader.GetInt32(3),
                            IdEntrenador = reader.GetInt32(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(4),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return asistencias;
        }

        public IEnumerable<Asistencia> ObtenerAsistenciasPorEntrenador(int idEntrenador)
        {
            List<Asistencia> asistencias = new List<Asistencia>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT a.Id, a.IdMiembro, a.Fecha, a.IdClase, a.IdEntrenador, m.Nombre, c.Nombre, e.Nombre
                FROM Asistencias a
                INNER JOIN Miembros m ON a.IdMiembro = m.Id
                INNER JOIN Clases c ON a.IdClase = c.Id
                INNER JOIN Entrenadores e ON a.IdEntrenador = e.Id 
                WHERE a.IdEntrenador = @IdEntrenador", conn);
                cmd.Parameters.AddWithValue("@IdEntrenador", idEntrenador);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asistencias.Add(new Asistencia
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            Fecha = reader.GetDateTime(2),
                            IdClase = reader.GetInt32(3),
                            IdEntrenador = reader.GetInt32(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(4),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return asistencias;
        }

        public IEnumerable<Asistencia> ObtenerAsistenciasPorMiembro(int idMiembro)
        {
            List<Asistencia> asistencias = new List<Asistencia>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT a.Id, a.IdMiembro, a.Fecha, a.IdClase, a.IdEntrenador, m.Nombre, c.Nombre, e.Nombre
                FROM Asistencias a
                INNER JOIN Miembros m ON a.IdMiembro = m.Id
                INNER JOIN Clases c ON a.IdClase = c.Id
                INNER JOIN Entrenadores e ON a.IdEntrenador = e.Id 
                WHERE a.IdMiembro = @IdMiembro", conn);
                cmd.Parameters.AddWithValue("@IdMiembro", idMiembro);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asistencias.Add(new Asistencia
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            Fecha = reader.GetDateTime(2),
                            IdClase = reader.GetInt32(3),
                            IdEntrenador = reader.GetInt32(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(4),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return asistencias;
        }
    }
}
