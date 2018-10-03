using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
   public partial class Cita
    {
        [Key]
        public int Id { get; set; }
        public string detalle { get; set; }
        public DateTime fecha { get; set; }
        public int Hora_salida { get; set; }
        public int Hora_LLegada { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        
    }
}
