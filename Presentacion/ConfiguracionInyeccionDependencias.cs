using Aplicacion;
using Aplicacion.Interfaces;
using Datos;
using Datos.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    public static class ConfiguracionInyeccionDependencias
    {
        public static void ConfigurarServicios(IServiceCollection servicios)
        {
            servicios.AddScoped<IRepositorioAsistencia, RepositorioAsistencia>();
            servicios.AddScoped<IServicioAsistencia, ServicioAsistencia>();

            servicios.AddScoped<IRepositorioClase, RepositorioClase>();
            servicios.AddScoped<IServicioClase, ServicioClase>();

            servicios.AddScoped<IRepositorioEntrenador, RepositorioEntrenador>();
            servicios.AddScoped<IServicioEntrenador, ServicioEntrenador>();

            servicios.AddScoped<IRepositorioGimnasio, RepositorioGimnasio>();
            servicios.AddScoped<IServicioGimnasio, ServicioGimnasio>();

            servicios.AddScoped<IRepositorioMembresia, RepositorioMembresia>();
            servicios.AddScoped<IServicioMembresia, ServicioMembresia>();

            servicios.AddScoped<IRepositorioMiembro, RepositorioMiembro>();
            servicios.AddScoped<IServicioMiembro, ServicioMiembro>();

            servicios.AddScoped<IRepositorioReservacion, RepositorioReservacion>();
            servicios.AddScoped<IServicioReservacion, ServicioReservacion>();

            servicios.AddScoped<IRepositorioUsuario, RepositorioUsuario>();
            servicios.AddScoped<IServicioUsuario, ServicioUsuario>();
        }
    }
}
