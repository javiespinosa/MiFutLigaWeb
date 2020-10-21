using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Horarios
    {
        public int idHorario { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int idDivision { get; set; }
        public string Hora { get; set; }

        public virtual Divisiones idDivisionNavigation { get; set; }
    }
}
