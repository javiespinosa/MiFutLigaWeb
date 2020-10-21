﻿using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Posiciones
    {
        public int idPosicion { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Posicion { get; set; }
        public bool Activo { get; set; }
    }
}
