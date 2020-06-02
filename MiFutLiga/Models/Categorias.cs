using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            Divisiones = new HashSet<Divisiones>();
            Equipos = new HashSet<Equipos>();
            Torneos = new HashSet<Torneos>();
        }

        public int idCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public bool? Abierta { get; set; }

        public virtual ICollection<Divisiones> Divisiones { get; set; }
        public virtual ICollection<Equipos> Equipos { get; set; }
        public virtual ICollection<Torneos> Torneos { get; set; }
    }
}
