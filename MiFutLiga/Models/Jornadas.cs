using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Jornadas
    {
        public Jornadas()
        {
            Juegos = new HashSet<Juegos>();
        }

        public int idJornada { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idTorneo { get; set; }
        public int? NumRonda { get; set; }
        public string NumJornada { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }

        public virtual Torneos idTorneoNavigation { get; set; }
        public virtual ICollection<Juegos> Juegos { get; set; }
    }
}
