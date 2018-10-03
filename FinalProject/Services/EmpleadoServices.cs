using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class EmpleadoServices : ICrudService<Empleado>
    {

        private readonly FinalProjectDbContext _DbContext;
        public EmpleadoServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public bool Add(Empleado model)
        {
            try
            {
                _DbContext.Empleados.Add(model);
                _DbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var resultado = _DbContext.Empleados.Find(id);
                _DbContext.Empleados.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
               

                throw;
            }
        }

        public Empleado Get(int id)
        {
            try
            {
                var resultado = _DbContext.Empleados.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Empleado> GetAll()
        {
            return _DbContext.Empleados.ToList();
        }

        public bool Update(Empleado model)
        {
            try
            {
                var result = _DbContext.Empleados.Single(x =>
                 x.Id == model.Id);

                if (result == null)

                _DbContext.Empleados.Update(model);
                _DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
