using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class TiposSancion
    {
        public TiposSancion()
        {
            Sanciones = new HashSet<Sanciones>();
        }

        public int idTipoSancion { get; set; }
        public string Descripcion { get; set; }
        public int? Valor { get; set; }

        public virtual ICollection<Sanciones> Sanciones { get; set; }
    }
}
