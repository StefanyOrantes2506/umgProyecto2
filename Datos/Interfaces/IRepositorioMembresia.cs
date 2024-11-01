using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioMembresia
    {
        IEnumerable<Membresia> ObtenerMembresias();
        Membresia ObtenerMembresia(int idMembresia);
        void AgregarMembresia(Membresia membresia);
        void ActualizarMembresia(Membresia membresia);
        void EliminarMembresia(int idMembresia);
    }
}
