using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Llista
    {
        public int idLLista { get; set; }
        public int idJuego { get; set; }
        public int idEquipo { get; set; }
        public int idJugador { get; set; }
        public bool Asistio { get; set; }
    }
}
