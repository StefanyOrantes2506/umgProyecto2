using System.ComponentModel;

namespace Dominio
{
    public class Reservacion
    {
        public int Id { get; set; }
        public int IdMiembro { get; set; }
        public int IdClase { get; set; }
        public int IdEntrenador { get; set; }
        public DateTime Fecha { get; set; }

        [Browsable(false)]
        public Miembro MiembroR { get; set; }
        [Browsable(false)]
        public Clase ClaseR { get; set; }
        [Browsable(false)]
        public Entrenador EntrenadorR { get; set; }

        public string Miembro
        {
            get
            {
                return MiembroR != null ? MiembroR.Nombre : "Sin miembro";
            }
        }

        public string Clase
        {
            get
            {
                return ClaseR != null ? ClaseR.Nombre : "Sin clase";
            }
        }
        public string Entrenador
        {
            get
            {
                return EntrenadorR != null ? EntrenadorR.Nombre : "Sin entrenador";
            }
        }
    }
}
