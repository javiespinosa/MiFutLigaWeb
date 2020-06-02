using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class HorasPorDia
    {
        public int idHoraPorDia { get; set; }
        public int? idDiaPorTorneo { get; set; }
        public int? idHora { get; set; }

        public virtual DiasPorTorneo idDiaPorTorneoNavigation { get; set; }
        public virtual Horas idHoraNavigation { get; set; }
    }
}
