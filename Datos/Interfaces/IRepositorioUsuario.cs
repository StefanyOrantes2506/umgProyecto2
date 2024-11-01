using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> ObtenerUsuarios();
        Usuario ObtenerUsuario(string nombreUsuario);
        void ActualizarUsuario(Usuario usuario);
        void AgregarUsuario(Usuario usuario);
        void EliminarUsuario(int idUsuario);
    }
}
