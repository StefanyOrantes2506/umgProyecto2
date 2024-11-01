using Dominio;

namespace Aplicacion.Interfaces
{
    public interface IServicioGimnasio
    {
        IEnumerable<Gimnasio> ObtenerGimnasios();
        Gimnasio ObtenerGimnasio(int idGimnasio);
        void AgregarGimnasio(Gimnasio gimnasio);
        void ActualizarGimnasio(Gimnasio gimnasio);
        void EliminarGimnasio(int idGimnasio);
    }
}
