using System.ComponentModel;

namespace Dominio
{
    public class Miembro : Persona
    {
        public int Id { get; set; }
        public int IdMembresia { get; set; }

        [Browsable(false)]
        public Membresia MembresiaR { get; set; }

        public string Membresia
        {
            get
            {
                return MembresiaR != null ? MembresiaR.Nombre : "Sin Membresía";
            }
        }
    }
}
