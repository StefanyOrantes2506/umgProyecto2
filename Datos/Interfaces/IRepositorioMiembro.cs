using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioMiembro
    {
        IEnumerable<Miembro> ObtenerMiembros();
        Miembro ObtenerMiembro(int idMiembro);
        void AgregarMiembro(Miembro miembro);
        void ActualizarMiembro(Miembro miembro);
        void EliminarMiembro(int idMiembro);
    }
}
