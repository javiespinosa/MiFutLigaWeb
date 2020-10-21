using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Finalistas
    {
        public int idFinalista { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idTorneo { get; set; }
        public int idEquipo { get; set; }
        public int? idGrupo { get; set; }
        public int Posinicial { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Grupos idGrupoNavigation { get; set; }
        public virtual Torneos idTorneoNavigation { get; set; }
    }
}
