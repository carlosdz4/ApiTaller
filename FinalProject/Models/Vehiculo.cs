using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
   public partial class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public int anio { get; set; }
        public string estado { get; set; }
        public string agencia { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

       // public List<Mantenimiento> Mantenimientos { get; set; }

    }
}
