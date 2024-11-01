using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioAsistencia
    {
        IEnumerable<Asistencia> ObtenerAsistencias();
        Asistencia ObtenerAsistencia(int idAsistencia);
        void AgregarAsistencia(Asistencia asistencia);
        void ActualizarAsistencia(Asistencia asistencia);
        void EliminarAsistencia(int idAsistencia);
        IEnumerable<Asistencia> ObtenerAsistenciasPorMiembro(int idMiembro);
        IEnumerable<Asistencia> ObtenerAsistenciasPorClase(int idClase);
        IEnumerable<Asistencia> ObtenerAsistenciasPorEntrenador(int idEntrenador);
    }
}
