using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioGimnasio : IRepositorioGimnasio
    {
        private readonly ContextoDatos contexto;

        public RepositorioGimnasio()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarGimnasio(Gimnasio gimnasio)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Gimnasios SET Nombre = @Nombre, Direccion = @Direccion, " +
                    "Telefono = @Telefono WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", gimnasio.Id);
                cmd.Parameters.AddWithValue("@Nombre", gimnasio.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", gimnasio.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", gimnasio.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarGimnasio(Gimnasio gimnasio)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Gimnasios (Nombre, Direccion, Telefono) " +
                    "VALUES (@Nombre, @Direccion, @Telefono)", conn);
                cmd.Parameters.AddWithValue("@Nombre", gimnasio.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", gimnasio.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", gimnasio.Telefono);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarGimnasio(int idGimnasio)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Gimnasios WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idGimnasio);
                cmd.ExecuteNonQuery();
            }
        }

        public Gimnasio ObtenerGimnasio(int idGimnasio)
        {
            Gimnasio gimnasio = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Gimnasios WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idGimnasio);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        gimnasio = new Gimnasio
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Direccion = reader.GetString(2),
                            Telefono = reader.GetString(3)
                        };
                    }
                }
            }

            return gimnasio;
        }

        public IEnumerable<Gimnasio> ObtenerGimnasios()
        {
            List<Gimnasio> gimnasios = new List<Gimnasio>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Gimnasios", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        gimnasios.Add(new Gimnasio
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Direccion = reader.GetString(2),
                            Telefono = reader.GetString(3)
                        });
                    }
                }
            }

            return gimnasios;
        }
    }
}
