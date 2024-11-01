using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class ContextoDatos
    {
        private readonly string? cadenaConexion;

        public ContextoDatos()
        {
            var configuracion = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            cadenaConexion = configuracion.GetConnectionString("GimnasioDB");
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
        public void Dispose()
        {

        }
    }
}
