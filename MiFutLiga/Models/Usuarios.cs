using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            PermisosPorUsuario = new HashSet<PermisosPorUsuario>();
            UsuariosPorEquipo = new HashSet<UsuariosPorEquipo>();
        }

        public int idUsuario { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<PermisosPorUsuario> PermisosPorUsuario { get; set; }
        public virtual ICollection<UsuariosPorEquipo> UsuariosPorEquipo { get; set; }
    }
}
