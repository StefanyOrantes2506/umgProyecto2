using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioClase
    {
        IEnumerable<Clase> ObtenerClases();
        Clase ObtenerClase(int idClase);
        void AgregarClase(Clase clase);
        void ActualizarClase(Clase clase);
        void EliminarClase(int idClase);
    }
}
