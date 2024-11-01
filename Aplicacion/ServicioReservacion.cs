using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Datos
{
    public class ServicioReservacion : IServicioReservacion
    {
        private readonly IRepositorioReservacion _repositorioReservacion;

        public ServicioReservacion(IRepositorioReservacion repositorioReservacion)
        {
            _repositorioReservacion = repositorioReservacion;
        }

        public void ActualizarReservacion(Reservacion reservacion)
        {
            _repositorioReservacion.ActualizarReservacion(reservacion);
        }

        public void AgregarReservacion(Reservacion reservacion)
        {
            _repositorioReservacion.AgregarReservacion(reservacion);
        }

        public void EliminarReservacion(int idReservacion)
        {
            _repositorioReservacion.EliminarReservacion(idReservacion);
        }

        public Reservacion ObtenerReservacion(int idReservacion)
        {
            return _repositorioReservacion.ObtenerReservacion(idReservacion);
        }

        public IEnumerable<Reservacion> ObtenerReservaciones()
        {
            return _repositorioReservacion.ObtenerReservaciones();
        }

        public IEnumerable<Reservacion> ObtenerReservacionesPorClase(int idClase)
        {
            return _repositorioReservacion.ObtenerReservacionesPorClase(idClase);
        }

        public IEnumerable<Reservacion> ObtenerReservacionesPorEntrenador(int idEntrenador)
        {
            return _repositorioReservacion.ObtenerReservacionesPorEntrenador(idEntrenador);
        }

        public IEnumerable<Reservacion> ObtenerReservacionesPorMiembro(int idMiembro)
        {
            return _repositorioReservacion.ObtenerReservacionesPorMiembro(idMiembro);
        }
    }
}
