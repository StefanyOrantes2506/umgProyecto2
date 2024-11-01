using Dominio;

namespace Datos.Interfaces
{
    public interface IRepositorioGimnasio
    {
        IEnumerable<Gimnasio> ObtenerGimnasios();
        Gimnasio ObtenerGimnasio(int idGimnasio);
        void AgregarGimnasio(Gimnasio gimnasio);
        void ActualizarGimnasio(Gimnasio gimnasio);
        void EliminarGimnasio(int idGimnasio);
    }
}
