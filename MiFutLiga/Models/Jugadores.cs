using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Jugadores
    {
        public Jugadores()
        {
            Goles = new HashSet<Goles>();
        }

        public int idJugador { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int idEquipo { get; set; }
        public int idTipoJugador { get; set; }
        public string NombreJugador { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? Numero { get; set; }
        public string Posicion { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Peso { get; set; }
        public short Edad { get; set; }
        public byte[] Fotografia { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public int? TipoJugador { get; set; }
        public bool Activo { get; set; }
        public string ContentType { get; set; }
        public string ruta { get; set; }
        public bool? Tomada { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual TiposJugador idTipoJugadorNavigation { get; set; }
        public virtual ICollection<Goles> Goles { get; set; }
    }
}
