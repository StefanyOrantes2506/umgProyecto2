using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioMembresia : IServicioMembresia
    {
        private readonly IRepositorioMembresia _repositorioMembresia;

        public ServicioMembresia(IRepositorioMembresia repositorioMembresia)
        {
            _repositorioMembresia = repositorioMembresia;
        }

        public void ActualizarMembresia(Membresia membresia)
        {
            _repositorioMembresia.ActualizarMembresia(membresia);
        }

        public void AgregarMembresia(Membresia membresia)
        {
            _repositorioMembresia.AgregarMembresia(membresia);
        }

        public void EliminarMembresia(int idMembresia)
        {
            _repositorioMembresia.EliminarMembresia(idMembresia);
        }

        public Membresia ObtenerMembresia(int idMembresia)
        {
            return _repositorioMembresia.ObtenerMembresia(idMembresia);
        }

        public IEnumerable<Membresia> ObtenerMembresias()
        {
            return _repositorioMembresia.ObtenerMembresias();
        }
    }
}
