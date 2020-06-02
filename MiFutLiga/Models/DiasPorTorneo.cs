using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class DiasPorTorneo
    {
        public DiasPorTorneo()
        {
            HorasPorDia = new HashSet<HorasPorDia>();
        }

        public int idDiaPorTorneo { get; set; }
        public int? idTorneo { get; set; }
        public int? idDia { get; set; }

        public virtual DiasSemana idDiaNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
        public virtual ICollection<HorasPorDia> HorasPorDia { get; set; }
    }
}
