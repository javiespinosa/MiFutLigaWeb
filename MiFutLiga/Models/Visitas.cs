using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Visitas
    {
        public int idVisita { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
        public int Status { get; set; }
    }
}
