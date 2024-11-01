using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioReservacion : IRepositorioReservacion
    {
        private readonly ContextoDatos contexto;

        public RepositorioReservacion()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarReservacion(Reservacion reservacion)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Reservaciones SET IdMiembro = @IdMiembro, IdClase = @IdClase, " +
                    "IdEntrenador = @IdEntrenador, Fecha = @Fecha WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", reservacion.Id);
                cmd.Parameters.AddWithValue("@IdMiembro", reservacion.IdMiembro);
                cmd.Parameters.AddWithValue("@IdClase", reservacion.IdClase);
                cmd.Parameters.AddWithValue("@IdEntrenador", reservacion.IdEntrenador);
                cmd.Parameters.AddWithValue("@Fecha", reservacion.Fecha);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarReservacion(Reservacion reservacion)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservaciones (IdMiembro, IdClase, IdEntrenador, Fecha) " +
                    "VALUES (@IdMiembro, @IdClase, @IdEntrenador, @Fecha)", conn);
                cmd.Parameters.AddWithValue("@IdMiembro", reservacion.IdMiembro);
                cmd.Parameters.AddWithValue("@IdClase", reservacion.IdClase);
                cmd.Parameters.AddWithValue("@IdEntrenador", reservacion.IdEntrenador);
                cmd.Parameters.AddWithValue("@Fecha", reservacion.Fecha);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarReservacion(int idReservacion)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reservaciones WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idReservacion);
                cmd.ExecuteNonQuery();
            }
        }

        public Reservacion ObtenerReservacion(int idReservacion)
        {
            Reservacion reservacion = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reservaciones WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idReservacion);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        reservacion = new Reservacion
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            IdClase = reader.GetInt32(2),
                            IdEntrenador = reader.GetInt32(3),
                            Fecha = reader.GetDateTime(4),
                        };
                    }
                }
            }

            return reservacion;
        }

        public IEnumerable<Reservacion> ObtenerReservaciones()
        {
            List<Reservacion> reservaciones = new List<Reservacion>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT r.Id, r.IdMiembro, r.IdClase, r.IdEntrenador, r.Fecha, m.Nombre, c.Nombre, e.Nombre
                FROM Reservaciones r
                INNER JOIN Miembros m ON r.IdMiembro = m.Id
                INNER JOIN Clases c ON r.IdClase = c.Id
                INNER JOIN Entrenadores e ON r.IdEntrenador = e.Id", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        reservaciones.Add(new Reservacion
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            IdClase = reader.GetInt32(2),
                            IdEntrenador = reader.GetInt32(3),
                            Fecha = reader.GetDateTime(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(2),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return reservaciones;
        }

        public IEnumerable<Reservacion> ObtenerReservacionesPorClase(int idClase)
        {
            List<Reservacion> reservaciones = new List<Reservacion>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT r.Id, r.IdMiembro, r.IdClase, r.IdEntrenador, r.Fecha, m.Nombre, c.Nombre, e.Nombre
                FROM Reservaciones r
                INNER JOIN Miembros m ON r.IdMiembro = m.Id
                INNER JOIN Clases c ON r.IdClase = c.Id
                INNER JOIN Entrenadores e ON r.IdEntrenador = e.Id
                WHERE r.IdClase = @IdClase", conn);
                cmd.Parameters.AddWithValue("@IdClase", idClase);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservaciones.Add(new Reservacion
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            IdClase = reader.GetInt32(2),
                            IdEntrenador = reader.GetInt32(3),
                            Fecha = reader.GetDateTime(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(2),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return reservaciones;
        }

        public IEnumerable<Reservacion> ObtenerReservacionesPorEntrenador(int idEntrenador)
        {
            List<Reservacion> reservaciones = new List<Reservacion>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT r.Id, r.IdMiembro, r.IdClase, r.IdEntrenador, r.Fecha, m.Nombre, c.Nombre, e.Nombre
                FROM Reservaciones r
                INNER JOIN Miembros m ON r.IdMiembro = m.Id
                INNER JOIN Clases c ON r.IdClase = c.Id
                INNER JOIN Entrenadores e ON r.IdEntrenador = e.Id
                WHERE r.IdEntrenador = @IdEntrenador", conn);
                cmd.Parameters.AddWithValue("@IdEntrenador", idEntrenador);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservaciones.Add(new Reservacion
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            IdClase = reader.GetInt32(2),
                            IdEntrenador = reader.GetInt32(3),
                            Fecha = reader.GetDateTime(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(2),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return reservaciones;
        }

        public IEnumerable<Reservacion> ObtenerReservacionesPorMiembro(int idMiembro)
        {
            List<Reservacion> reservaciones = new List<Reservacion>();

            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT r.Id, r.IdMiembro, r.IdClase, r.IdEntrenador, r.Fecha, m.Nombre, c.Nombre, e.Nombre
                FROM Reservaciones r
                INNER JOIN Miembros m ON r.IdMiembro = m.Id
                INNER JOIN Clases c ON r.IdClase = c.Id
                INNER JOIN Entrenadores e ON r.IdEntrenador = e.Id
                WHERE r.IdMiembro = @IdMiembro", conn);
                cmd.Parameters.AddWithValue("@IdMiembro", idMiembro);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservaciones.Add(new Reservacion
                        {
                            Id = reader.GetInt32(0),
                            IdMiembro = reader.GetInt32(1),
                            IdClase = reader.GetInt32(2),
                            IdEntrenador = reader.GetInt32(3),
                            Fecha = reader.GetDateTime(4),

                            MiembroR = new Miembro
                            {
                                Id = reader.GetInt32(1),
                                Nombre = reader.GetString(5),
                            },
                            ClaseR = new Clase
                            {
                                Id = reader.GetInt32(2),
                                Nombre = reader.GetString(6),
                            },
                            EntrenadorR = new Entrenador
                            {
                                Id = reader.GetInt32(3),
                                Nombre = reader.GetString(7),
                            },
                        });
                    }
                }
            }

            return reservaciones;
        }
    }
}
