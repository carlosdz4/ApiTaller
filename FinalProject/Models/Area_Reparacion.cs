using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
  public partial  class Area_Reparacion
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int descripcion { get; set; }
      //  public List<Factura> Facturas { get; set; }
    }
}
