using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioAsistencia : IServicioAsistencia
    {
        private readonly IRepositorioAsistencia _repositorioAsistencia;

        public ServicioAsistencia(IRepositorioAsistencia repositorioAsistencia)
        {
            _repositorioAsistencia = repositorioAsistencia;
        }

        public void ActualizarAsistencia(Asistencia asistencia)
        {
            _repositorioAsistencia.ActualizarAsistencia(asistencia);
        }

        public void AgregarAsistencia(Asistencia asistencia)
        {
            _repositorioAsistencia.AgregarAsistencia(asistencia);
        }

        public void EliminarAsistencia(int idAsistencia)
        {
            _repositorioAsistencia.EliminarAsistencia(idAsistencia);
        }

        public Asistencia ObtenerAsistencia(int idAsistencia)
        {
            return _repositorioAsistencia.ObtenerAsistencia(idAsistencia);
        }

        public IEnumerable<Asistencia> ObtenerAsistencias()
        {
            return _repositorioAsistencia.ObtenerAsistencias();
        }

        public IEnumerable<Asistencia> ObtenerAsistenciasPorClase(int idClase)
        {
            return _repositorioAsistencia.ObtenerAsistenciasPorClase(idClase);
        }

        public IEnumerable<Asistencia> ObtenerAsistenciasPorEntrenador(int idEntrenador)
        {
            return _repositorioAsistencia.ObtenerAsistenciasPorEntrenador(idEntrenador);
        }

        public IEnumerable<Asistencia> ObtenerAsistenciasPorMiembro(int idMiembro)
        {
            return _repositorioAsistencia.ObtenerAsistenciasPorMiembro(idMiembro);
        }
    }
}
