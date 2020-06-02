using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Temporadas
    {
        public Temporadas()
        {
            Calendario = new HashSet<Calendario>();
        }

        public int idTemporada { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Calendario> Calendario { get; set; }
    }
}
