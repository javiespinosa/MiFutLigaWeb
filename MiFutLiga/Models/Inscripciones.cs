using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Inscripciones
    {
        public int idInscripcion { get; set; }
        public int? idTorneo { get; set; }
        public int? idEquipo { get; set; }
        public DateTime? FechaInscripcion { get; set; }
        public bool? Residencia { get; set; }
        public bool? Finalista { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
