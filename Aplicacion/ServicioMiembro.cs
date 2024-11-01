using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioMiembro : IServicioMiembro
    {
        private readonly IRepositorioMiembro _repositorioMiembro;

        public ServicioMiembro(IRepositorioMiembro repositorioMiembro)
        {
            _repositorioMiembro = repositorioMiembro;
        }

        public void ActualizarMiembro(Miembro miembro)
        {
            _repositorioMiembro.ActualizarMiembro(miembro);
        }

        public void AgregarMiembro(Miembro miembro)
        {
            _repositorioMiembro.AgregarMiembro(miembro);
        }

        public void EliminarMiembro(int idMiembro)
        {
            _repositorioMiembro.EliminarMiembro(idMiembro);
        }

        public Miembro ObtenerMiembro(int idMiembro)
        {
            return _repositorioMiembro.ObtenerMiembro(idMiembro);
        }

        public IEnumerable<Miembro> ObtenerMiembros()
        {
            return _repositorioMiembro.ObtenerMiembros();
        }
    }
}
