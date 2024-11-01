using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioMiembro
    {
        IEnumerable<Miembro> ObtenerMiembros();
        Miembro ObtenerMiembro(int idMiembro);
        void AgregarMiembro(Miembro miembro);
        void ActualizarMiembro(Miembro miembro);
        void EliminarMiembro(int idMiembro);
    }
}
