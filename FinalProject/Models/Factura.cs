using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
   public partial   class Factura
    {
        [Key]
        public int Id { get; set; }
        public string Garantia { get; set; }
        public string Costo { get; set; }
        public int Area_ReparacionId { get; set; }
        public Area_Reparacion Area_Reparacion { get; set; }
     //   public List<Mantenimiento> Mantenimientos { get; set; }
    }
}
