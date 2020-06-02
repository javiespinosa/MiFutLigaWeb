using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class GruposDetalle
    {
        public int idGruposDetalle { get; set; }
        public int? idGrupo { get; set; }
        public int? idTorneo { get; set; }

        public virtual Grupos idGrupoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
