using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class FechasDeJuego
    {
        public int idFechaDeJuego { get; set; }
        public int? idJuego { get; set; }
        public int? idCalendario { get; set; }

        public virtual Calendario idCalendarioNavigation { get; set; }
        public virtual Juegos idJuegoNavigation { get; set; }
    }
}
