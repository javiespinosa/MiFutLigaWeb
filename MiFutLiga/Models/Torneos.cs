using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Torneos
    {
        public Torneos()
        {
            Calendario = new HashSet<Calendario>();
            CalendarioTorneos = new HashSet<CalendarioTorneos>();
            DiasPorTorneo = new HashSet<DiasPorTorneo>();
            Finalistas = new HashSet<Finalistas>();
            GruposDetalle = new HashSet<GruposDetalle>();
            Inscripciones = new HashSet<Inscripciones>();
            Jornadas = new HashSet<Jornadas>();
            Juegos = new HashSet<Juegos>();
            JuegosSF = new HashSet<JuegosSF>();
            Puntuacion = new HashSet<Puntuacion>();
            ReservacionesDeEquipo = new HashSet<ReservacionesDeEquipo>();
        }

        public int idTorneo { get; set; }
        public int? idCategoria { get; set; }
        public int? idDivision { get; set; }
        public string NombreTorneo { get; set; }
        public DateTime? FechaApertura { get; set; }
        public bool? Abierto { get; set; }
        public bool? Cerrado { get; set; }
        public DateTime? FechaCierre { get; set; }
        public bool? DobleRonda { get; set; }
        public bool? Publicado { get; set; }

        public virtual Categorias idCategoriaNavigation { get; set; }
        public virtual Divisiones idDivisionNavigation { get; set; }
        public virtual ICollection<Calendario> Calendario { get; set; }
        public virtual ICollection<CalendarioTorneos> CalendarioTorneos { get; set; }
        public virtual ICollection<DiasPorTorneo> DiasPorTorneo { get; set; }
        public virtual ICollection<Finalistas> Finalistas { get; set; }
        public virtual ICollection<GruposDetalle> GruposDetalle { get; set; }
        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
        public virtual ICollection<Jornadas> Jornadas { get; set; }
        public virtual ICollection<Juegos> Juegos { get; set; }
        public virtual ICollection<JuegosSF> JuegosSF { get; set; }
        public virtual ICollection<Puntuacion> Puntuacion { get; set; }
        public virtual ICollection<ReservacionesDeEquipo> ReservacionesDeEquipo { get; set; }
    }
}
