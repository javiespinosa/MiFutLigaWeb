using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Sanciones
    {
        public int idSancion { get; set; }
        public int idJuego { get; set; }
        public int idEquipo { get; set; }
        public int Sancionado { get; set; }
        public int idTipoSancion { get; set; }
        public string Motivo { get; set; }
        public int? Castigo { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Juegos idJuegoNavigation { get; set; }
        public virtual TiposSancion idTipoSancionNavigation { get; set; }
    }
}
