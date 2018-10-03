using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public partial class Cliente
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string direccion { get; set; }
        public string Cedula { get; set; }
      //  public List <Vehiculo> vehiculos { get; set; }
      //  public List<Empleado_Atiende> Empleado_Atiendes { get; set; }
       // public List<Cita> Citas { get; set; }
    }
}
