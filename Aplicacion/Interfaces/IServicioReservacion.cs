using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioReservacion
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
