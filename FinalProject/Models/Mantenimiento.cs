using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
   public partial class Mantenimiento
    {
        [Key]
        public int Id  { get; set; }
        public DateTime Fecha_entrada { get; set; }
        public DateTime Fecha_salida { get; set; }
        public int VehiculoId { get; set; }
        public int MecanicosId { get; set; }
        public int FacturaId { get; set; }

        public Vehiculo Vehiculo { get; set; }
        public Mecanicos Mecanicos { get; set; }
        public Factura Factura { get; set; }

        
    }
}
