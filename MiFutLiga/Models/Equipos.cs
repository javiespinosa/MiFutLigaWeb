using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Equipos
    {
        public Equipos()
        {
            Finalistas = new HashSet<Finalistas>();
            Goles = new HashSet<Goles>();
            Inscripciones = new HashSet<Inscripciones>();
            Jugadores = new HashSet<Jugadores>();
            Puntuacion = new HashSet<Puntuacion>();
            ReservacionesDeEquipo = new HashSet<ReservacionesDeEquipo>();
            Sanciones = new HashSet<Sanciones>();
            UsuariosPorEquipo = new HashSet<UsuariosPorEquipo>();
        }

        public int idEquipo { get; set; }
        public int idCategoria { get; set; }
        public int idDivision { get; set; }
        public string NombreEquipo { get; set; }
        public string Delegado { get; set; }
        public string DirTecnico { get; set; }
        public int? ColorCamiseta { get; set; }
        public int? ColorShort { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public byte[] Escudo { get; set; }
        public string ContentType { get; set; }
        public string Auxiliar { get; set; }
        public string Medico { get; set; }
        public string ruta { get; set; }
        public int? Apoyos { get; set; }
        public string fotoequipo { get; set; }

        public virtual Categorias idCategoriaNavigation { get; set; }
        public virtual Divisiones idDivisionNavigation { get; set; }
        public virtual ICollection<Finalistas> Finalistas { get; set; }
        public virtual ICollection<Goles> Goles { get; set; }
        public virtual ICollection<Inscripciones> Inscripciones { get; set; }
        public virtual ICollection<Jugadores> Jugadores { get; set; }
        public virtual ICollection<Puntuacion> Puntuacion { get; set; }
        public virtual ICollection<ReservacionesDeEquipo> ReservacionesDeEquipo { get; set; }
        public virtual ICollection<Sanciones> Sanciones { get; set; }
        public virtual ICollection<UsuariosPorEquipo> UsuariosPorEquipo { get; set; }
    }
}
