using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Colores
    {
        public int idColor { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Descripcion { get; set; }
    }
}
