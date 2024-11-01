using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioEntrenador
    {
        IEnumerable<Entrenador> ObtenerEntrenadores();
        Entrenador ObtenerEntrenador(int idEntrenador);
        void AgregarEntrenador(Entrenador entrenador);
        void ActualizarEntrenador(Entrenador entrenador);
        void EliminarEntrenador(int idEntrenador);
    }
}
