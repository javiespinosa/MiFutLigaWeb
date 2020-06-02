﻿using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Modulos
    {
        public Modulos()
        {
            PermisosPorUsuario = new HashSet<PermisosPorUsuario>();
        }

        public int idModulo { get; set; }
        public string Descripcion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<PermisosPorUsuario> PermisosPorUsuario { get; set; }
    }
}
