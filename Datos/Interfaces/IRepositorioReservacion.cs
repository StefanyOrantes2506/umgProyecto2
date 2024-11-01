using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioReservacion
    {
        IEnumerable<Reservacion> ObtenerReservaciones();
        Reservacion ObtenerReservacion(int idReservacion);
        void AgregarReservacion(Reservacion reservacion);
        void ActualizarReservacion(Reservacion reservacion);
        void EliminarReservacion(int idReservacion);
        IEnumerable<Reservacion> ObtenerReservacionesPorMiembro(int idMiembro);
        IEnumerable<Reservacion> ObtenerReservacionesPorClase(int idClase);
        IEnumerable<Reservacion> ObtenerReservacionesPorEntrenador(int idEntrenador);
    }
}
