using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class PermisosPorUsuario
    {
        public int idPermisoPorUsuario { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idModulo { get; set; }
        public int? idUsuario { get; set; }
        public int? idPermiso { get; set; }

        public virtual Modulos idModuloNavigation { get; set; }
        public virtual Permisos idPermisoNavigation { get; set; }
        public virtual Usuarios idUsuarioNavigation { get; set; }
    }
}
