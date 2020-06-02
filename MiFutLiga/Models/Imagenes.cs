using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Imagenes
    {
        public int idImagen { get; set; }
        public int idTema { get; set; }
        public byte[] imagen { get; set; }
        public string ContentType { get; set; }

        public virtual Temas idTemaNavigation { get; set; }
    }
}
