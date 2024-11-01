using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioClase : IServicioClase
    {
        private readonly IRepositorioClase _repositorioClase;

        public ServicioClase(IRepositorioClase repositorioClase)
        {
            _repositorioClase = repositorioClase;
        }

        public void ActualizarClase(Clase clase)
        {
            _repositorioClase.ActualizarClase(clase);
        }

        public void AgregarClase(Clase clase)
        {
            _repositorioClase.AgregarClase(clase);
        }

        public void EliminarClase(int idClase)
        {
            _repositorioClase.EliminarClase(idClase);
        }

        public Clase ObtenerClase(int idClase)
        {
            return _repositorioClase.ObtenerClase(idClase);
        }

        public IEnumerable<Clase> ObtenerClases()
        {
            return _repositorioClase.ObtenerClases();
        }
    }
}
