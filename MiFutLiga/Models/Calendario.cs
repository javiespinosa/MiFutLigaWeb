using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Calendario
    {
        public Calendario()
        {
            CalendarioTorneos = new HashSet<CalendarioTorneos>();
            FechasDeJuego = new HashSet<FechasDeJuego>();
            Juegos = new HashSet<Juegos>();
            JuegosSF = new HashSet<JuegosSF>();
            ReservacionesDeEquipo = new HashSet<ReservacionesDeEquipo>();
        }

        public int idCalendario { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idDia { get; set; }
        public int? idHora { get; set; }
        public int? idTemporada { get; set; }
        public int? idTorneo { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? Reservado { get; set; }

        public virtual DiasSemana idDiaNavigation { get; set; }
        public virtual Horas idHoraNavigation { get; set; }
        public virtual Temporadas idTemporadaNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
        public virtual ICollection<CalendarioTorneos> CalendarioTorneos { get; set; }
        public virtual ICollection<FechasDeJuego> FechasDeJuego { get; set; }
        public virtual ICollection<Juegos> Juegos { get; set; }
        public virtual ICollection<JuegosSF> JuegosSF { get; set; }
        public virtual ICollection<ReservacionesDeEquipo> ReservacionesDeEquipo { get; set; }
    }
}
