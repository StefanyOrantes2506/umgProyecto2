using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioAsistencia
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
