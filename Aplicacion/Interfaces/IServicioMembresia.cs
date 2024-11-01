using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioMembresia
    {
        IEnumerable<Membresia> ObtenerMembresias();
        Membresia ObtenerMembresia(int idMembresia);
        void AgregarMembresia(Membresia membresia);
        void ActualizarMembresia(Membresia membresia);
        void EliminarMembresia(int idMembresia);
    }
}
