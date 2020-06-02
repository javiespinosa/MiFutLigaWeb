using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Juegos
    {
        public Juegos()
        {
            FechasDeJuego = new HashSet<FechasDeJuego>();
            Goles = new HashSet<Goles>();
            Sanciones = new HashSet<Sanciones>();
        }

        public int idJuego { get; set; }
        public int? idJornada { get; set; }
        public int? idCalendario { get; set; }
        public int? Local { get; set; }
        public int? Visitante { get; set; }
        public bool Activo { get; set; }
        public int? Ganador { get; set; }
        public int? IdTorneo { get; set; }
        public string Observaciones { get; set; }

        public virtual Torneos IdTorneoNavigation { get; set; }
        public virtual Calendario idCalendarioNavigation { get; set; }
        public virtual Jornadas idJornadaNavigation { get; set; }
        public virtual ICollection<FechasDeJuego> FechasDeJuego { get; set; }
        public virtual ICollection<Goles> Goles { get; set; }
        public virtual ICollection<Sanciones> Sanciones { get; set; }
    }
}
