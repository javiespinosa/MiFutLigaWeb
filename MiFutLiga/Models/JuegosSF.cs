using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class JuegosSF
    {
        public int idJuegoSF { get; set; }
        public int? idCalendario { get; set; }
        public int? EqVisitante { get; set; }
        public int? EqLocal { get; set; }
        public bool Activo { get; set; }
        public int? Ganador { get; set; }
        public int? idTorneo { get; set; }
        public int NumJuego { get; set; }
        public int? GolesVisitante { get; set; }
        public int? GolesLocal { get; set; }
        public int? Jornada { get; set; }
        public int? idGrupo { get; set; }

        public virtual Calendario idCalendarioNavigation { get; set; }
        public virtual Grupos idGrupoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
