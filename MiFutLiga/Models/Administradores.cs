using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Administradores
    {
        public int idAdministrador { get; set; }
        public DateTime Agregado { get; set; }
        public DateTime? Modificado { get; set; }
        public bool Eliminado { get; set; }
        public string Login { get; set; }
        public string Contrasenia { get; set; }
    }
}
