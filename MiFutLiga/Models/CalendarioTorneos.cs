using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class CalendarioTorneos
    {
        public int idCalendarioTorneo { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idTorneo { get; set; }
        public int? idCalendario { get; set; }

        public virtual Calendario idCalendarioNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
