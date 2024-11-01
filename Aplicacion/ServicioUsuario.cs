using Aplicacion.Interfaces;
using Datos.Interfaces;
using Dominio;

namespace Aplicacion
{
    public class ServicioUsuario : IServicioUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public ServicioUsuario(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public bool Login(string nombreUsuario, string contrasenia)
        {
            var usuario = _repositorioUsuario.ObtenerUsuario(nombreUsuario);
            return usuario != null && usuario.Contrasenia == contrasenia;
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            return _repositorioUsuario.ObtenerUsuarios();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _repositorioUsuario.AgregarUsuario(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _repositorioUsuario.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
            _repositorioUsuario.EliminarUsuario(idUsuario);
        }
    }
}
