using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Divisiones
    {
        public Divisiones()
        {
            Equipos = new HashSet<Equipos>();
            Horarios = new HashSet<Horarios>();
            Torneos = new HashSet<Torneos>();
        }

        public int idDivision { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int idCategoria { get; set; }
        public string NombreDivision { get; set; }
        public int? EdadMinima { get; set; }
        public int? EdadMaxima { get; set; }

        public virtual Categorias idCategoriaNavigation { get; set; }
        public virtual ICollection<Equipos> Equipos { get; set; }
        public virtual ICollection<Horarios> Horarios { get; set; }
        public virtual ICollection<Torneos> Torneos { get; set; }
    }
}
