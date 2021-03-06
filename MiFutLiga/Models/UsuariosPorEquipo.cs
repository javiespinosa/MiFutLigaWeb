﻿using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class UsuariosPorEquipo
    {
        public int IdUsuarioPorEquipo { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public int? idEquipo { get; set; }
        public int? idUsuario { get; set; }

        public virtual Equipos idEquipoNavigation { get; set; }
        public virtual Usuarios idUsuarioNavigation { get; set; }
    }
}
