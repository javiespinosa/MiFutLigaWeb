using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Noticias
    {
        public int id_Noticias { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Titulo { get; set; }
        public DateTime? Fecha_publica { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public string Contenido { get; set; }
        public bool? Activo { get; set; }
        public string Resumen { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
    }
}
