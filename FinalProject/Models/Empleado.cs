using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
  public partial  class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Usario { get; set; }
        public string Contraseña { get; set; }
     //   public List<Empleado_Atiende> Empleado_Atiendes { get; set; }
    }
}
