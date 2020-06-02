using System;
using System.Collections.Generic;

namespace MiFutLiga.Models
{
    public partial class Comentarios
    {
        public int idComentario { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int idParticipante { get; set; }
        public int idTema { get; set; }
        public string Comentario { get; set; }
        public int Status { get; set; }

        public virtual Participantes idParticipanteNavigation { get; set; }
        public virtual Temas idTemaNavigation { get; set; }
    }
}
