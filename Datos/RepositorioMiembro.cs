using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioMiembro : IRepositorioMiembro
    {
        private readonly ContextoDatos contexto;

        public RepositorioMiembro()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarMiembro(Miembro miembro)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Miembros SET Nombre = @Nombre, Apellido = @Apellido, " +
                    "Edad = @Edad, IdMembresia = @IdMembresia WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", miembro.Id);
                cmd.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                cmd.Parameters.AddWithValue("@Edad", miembro.Edad);
                cmd.Parameters.AddWithValue("@IdMembresia", miembro.IdMembresia);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarMiembro(Miembro miembro)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Miembros (Nombre, Apellido, Edad, IdMembresia) " +
                    "VALUES (@Nombre, @Apellido, @Edad, @IdMembresia)", conn);
                cmd.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                cmd.Parameters.AddWithValue("@Edad", miembro.Edad);
                cmd.Parameters.AddWithValue("@IdMembresia", miembro.IdMembresia);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarMiembro(int idMiembro)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Miembros WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idMiembro);
                cmd.ExecuteNonQuery();
            }
        }

        public Miembro ObtenerMiembro(int idMiembro)
        {
            Miembro miembro = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Miembros WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idMiembro);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        miembro = new Miembro
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Edad = reader.GetInt32(3),
                            IdMembresia = reader.GetInt32(4),
                        };
                    }
                }
            }

            return miembro;
        }

        public IEnumerable<Miembro> ObtenerMiembros()
        {
            List<Miembro> miembros = new List<Miembro>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT m.Id, m.Nombre, m.Apellido, m.Edad, m.IdMembresia, mb.Nombre 
                FROM Miembros m
                INNER JOIN Membresias mb ON m.IdMembresia = mb.Id", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        miembros.Add(new Miembro
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Edad = reader.GetInt32(3),
                            IdMembresia = reader.GetInt32(4),

                            MembresiaR = new Membresia {
                                Id = reader.GetInt32(4),
                                Nombre = reader.GetString(5),
                            }
                        });
                    }
                }
            }

            return miembros;
        }
    }
}
