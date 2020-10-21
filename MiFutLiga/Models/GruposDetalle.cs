using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class GruposDetalle
    {
        public int idGruposDetalle { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idGrupo { get; set; }
        public int? idTorneo { get; set; }

        public virtual Grupos idGrupoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
