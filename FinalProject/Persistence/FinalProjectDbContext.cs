using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace Persistence
{
    public class FinalProjectDbContext : DbContext  
    {
        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options)
            :base(options){  }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Empleado_Atiende> Empleado_Atiendes { get; set; }
        public DbSet<Mecanicos> Mecanicos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Area_Reparacion> Area_Reparacions { get; set; }

    }
}
