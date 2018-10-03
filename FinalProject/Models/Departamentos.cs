using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
   public partial class Departamentos
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int descripcion { get; set; }

       // public virtual List<Mecanicos> Mecanicos { get; set; }

    }
}
