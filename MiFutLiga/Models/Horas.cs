using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Horas
    {
        public Horas()
        {
            Calendario = new HashSet<Calendario>();
            HorasPorDia = new HashSet<HorasPorDia>();
            Prereservaciones = new HashSet<Prereservaciones>();
        }

        public int idHora { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Calendario> Calendario { get; set; }
        public virtual ICollection<HorasPorDia> HorasPorDia { get; set; }
        public virtual ICollection<Prereservaciones> Prereservaciones { get; set; }
    }
}
