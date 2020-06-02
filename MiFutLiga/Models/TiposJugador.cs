using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class TiposJugador
    {
        public TiposJugador()
        {
            Jugadores = new HashSet<Jugadores>();
        }

        public int idTipoJugador { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Jugadores> Jugadores { get; set; }
    }
}
