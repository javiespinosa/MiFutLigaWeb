using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Temas
    {
        public Temas()
        {
            Comentarios = new HashSet<Comentarios>();
            Imagenes = new HashSet<Imagenes>();
        }

        public int idTema { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Comentarios> Comentarios { get; set; }
        public virtual ICollection<Imagenes> Imagenes { get; set; }
    }
}
