using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Grupos
    {
        public Grupos()
        {
            Finalistas = new HashSet<Finalistas>();
            GruposDetalle = new HashSet<GruposDetalle>();
            JuegosSF = new HashSet<JuegosSF>();
        }

        public int idGrupo { get; set; }
        public string NombreGrupo { get; set; }
        public int? NumEquipos { get; set; }

        public virtual ICollection<Finalistas> Finalistas { get; set; }
        public virtual ICollection<GruposDetalle> GruposDetalle { get; set; }
        public virtual ICollection<JuegosSF> JuegosSF { get; set; }
    }
}
