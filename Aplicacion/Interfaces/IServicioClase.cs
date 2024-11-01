using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioClase
    {
        IEnumerable<Clase> ObtenerClases();
        Clase ObtenerClase(int idClase);
        void AgregarClase(Clase clase);
        void ActualizarClase(Clase clase);
        void EliminarClase(int idClase);
    }
}
