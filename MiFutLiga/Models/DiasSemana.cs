using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class DiasSemana
    {
        public DiasSemana()
        {
            Calendario = new HashSet<Calendario>();
            DiasPorTorneo = new HashSet<DiasPorTorneo>();
        }

        public int idDia { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Calendario> Calendario { get; set; }
        public virtual ICollection<DiasPorTorneo> DiasPorTorneo { get; set; }
    }
}
