using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioGimnasio : IServicioGimnasio
    {
        private readonly IRepositorioGimnasio _repositorioGimnasio;

        public ServicioGimnasio(IRepositorioGimnasio repositorioGimnasio)
        {
            _repositorioGimnasio = repositorioGimnasio;
        }

        public void ActualizarGimnasio(Gimnasio gimnasio)
        {
            _repositorioGimnasio.ActualizarGimnasio(gimnasio);
        }

        public void AgregarGimnasio(Gimnasio gimnasio)
        {
            _repositorioGimnasio.AgregarGimnasio(gimnasio);
        }

        public void EliminarGimnasio(int idGimnasio)
        {
            _repositorioGimnasio.EliminarGimnasio(idGimnasio);
        }

        public Gimnasio ObtenerGimnasio(int idGimnasio)
        {
            return _repositorioGimnasio.ObtenerGimnasio(idGimnasio);
        }

        public IEnumerable<Gimnasio> ObtenerGimnasios()
        {
            return _repositorioGimnasio.ObtenerGimnasios();
        }
    }
}
