using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Puntuacion
    {
        public int idPuntuacion { get; set; }
        public int? idTorneo { get; set; }
        public int? idEquipo { get; set; }
        public int? PJ { get; set; }
        public int? PG { get; set; }
        public int? PP { get; set; }
        public int? PE { get; set; }
        public int? PFavor { get; set; }
        public int? PContra { get; set; }
        public int? GolFavor { get; set; }
        public int? GolContra { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
