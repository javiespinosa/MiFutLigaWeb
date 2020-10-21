using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Participantes
    {
        public Participantes()
        {
            Comentarios = new HashSet<Comentarios>();
        }

        public int idParticipante { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Contrasenia { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Comentarios> Comentarios { get; set; }
    }
}
