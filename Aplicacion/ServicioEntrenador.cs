using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioEntrenador : IServicioEntrenador
    {
        private readonly IRepositorioEntrenador _repositorioEntrenador;

        public ServicioEntrenador(IRepositorioEntrenador repositorioEntrenador)
        {
            _repositorioEntrenador = repositorioEntrenador;
        }

        public void ActualizarEntrenador(Entrenador entrenador)
        {
            _repositorioEntrenador.ActualizarEntrenador(entrenador);
        }

        public void AgregarEntrenador(Entrenador entrenador)
        {
            _repositorioEntrenador.AgregarEntrenador(entrenador);
        }

        public void EliminarEntrenador(int idEntrenador)
        {
            _repositorioEntrenador.EliminarEntrenador(idEntrenador);
        }

        public Entrenador ObtenerEntrenador(int idEntrenador)
        {
           return _repositorioEntrenador.ObtenerEntrenador(idEntrenador);
        }

        public IEnumerable<Entrenador> ObtenerEntrenadores()
        {
            return _repositorioEntrenador.ObtenerEntrenadores();
        }
    }
}
