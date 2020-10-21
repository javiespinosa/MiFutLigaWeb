using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Prereservaciones
    {
        public int idPreReservacion { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string NombreSolicitante { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int? idHora { get; set; }
        public DateTime? FechaSolicitada { get; set; }
        public bool? Confirmado { get; set; }

        public virtual Horas idHoraNavigation { get; set; }
    }
}
