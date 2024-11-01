using System.ComponentModel;

namespace Dominio
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Horario { get; set; }
        public int IdEntrenador { get; set; }
        public int IdGimnasio { get; set; }

        [Browsable(false)]
        public Entrenador EntrenadorR { get; set; }
        [Browsable(false)]
        public Gimnasio GimnasioR { get; set; }

        public string Entrenador
        {
            get
            {
                return EntrenadorR != null ? EntrenadorR.Nombre : "Sin entrenador";
            }
        }

        public string Gimnasio
        {
            get
            {
                return GimnasioR != null ? GimnasioR.Nombre : "Sin gimnasio";
            }
        }
    }
}
