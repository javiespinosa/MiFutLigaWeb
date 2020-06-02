using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Goles
    {
        public int idGol { get; set; }
        public int idJuego { get; set; }
        public int? idEquipo { get; set; }
        public int? idJugador { get; set; }
        public string MinutoAnotacion { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Juegos idJuegoNavigation { get; set; }
        public virtual Jugadores idJugadorNavigation { get; set; }
    }
}
