using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public partial class Mecanicos
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int departamentosId { get; set; }
        public Departamentos departamentos { get; set; }

       // public List<Mantenimiento> Mantenimientos { get; set; }



    }
}
