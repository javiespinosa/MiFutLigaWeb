using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class ReservacionesDeEquipo
    {
        public int idReservacionDeEquipo { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idEquipo { get; set; }
        public int? idTorneo { get; set; }
        public int? idCalendario { get; set; }

        public virtual Calendario idCalendarioNavigation { get; set; }
        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
