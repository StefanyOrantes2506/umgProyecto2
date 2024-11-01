using Datos.Interfaces;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioMembresia : IRepositorioMembresia
    {
        private readonly ContextoDatos contexto;

        public RepositorioMembresia()
        {
            contexto = new ContextoDatos();
        }

        public void ActualizarMembresia(Membresia membresia)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Membresias SET Nombre = @Nombre WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", membresia.Id);
                cmd.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarMembresia(Membresia membresia)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Membresias (Nombre) VALUES (@Nombre)", conn);
                cmd.Parameters.AddWithValue("@Nombre", membresia.Nombre);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarMembresia(int idMembresia)
        {
            using (SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Membresias WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idMembresia);
                cmd.ExecuteNonQuery();
            }
        }

        public Membresia ObtenerMembresia(int idMembresia)
        {
            Membresia membresia = null;

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Membresias WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idMembresia);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        membresia = new Membresia
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        };
                    }
                }
            }

            return membresia;
        }

        public IEnumerable<Membresia> ObtenerMembresias()
        {
            List<Membresia> membresias = new List<Membresia>();

            using(SqlConnection conn = contexto.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Membresias", conn);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        membresias.Add(new Membresia
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        });
                    }
                }
            }

            return membresias;
        }
    }
}
