using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioUsuario
    {
        bool Login(string nombreUsuario, string contrasenia);
        IEnumerable<Usuario> ObtenerUsuarios();
        void AgregarUsuario(Usuario usuario);
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int idUsuario);
    }
}
