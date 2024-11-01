using Aplicacion.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfiguracionInyeccionDependencias.ConfigurarServicios(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(serviceProvider));
        }
    }
}