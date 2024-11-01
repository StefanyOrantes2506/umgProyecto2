using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioEntrenador
    {
        IEnumerable<Entrenador> ObtenerEntrenadores();
        Entrenador ObtenerEntrenador(int idEntrenador);
        void AgregarEntrenador(Entrenador entrenador);
        void ActualizarEntrenador(Entrenador entrenador);
        void EliminarEntrenador(int idEntrenador);
    }
}
