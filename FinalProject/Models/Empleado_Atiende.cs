using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public partial class Empleado_Atiende
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }

    }
}
