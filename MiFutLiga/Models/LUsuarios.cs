using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class LUsuarios
    {
        public int idLUsuario { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }
        public int Estatus { get; set; }
        public DateTime VencimientoPassword { get; set; }
    }
}
