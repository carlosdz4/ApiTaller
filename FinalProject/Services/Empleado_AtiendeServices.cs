
using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class Empleado_AtiendeServices : ICrudService<Empleado_Atiende>
    {

        private readonly FinalProjectDbContext _DbContext;
        public Empleado_AtiendeServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public bool Add(Empleado_Atiende model)
        {
            try
            {
                _DbContext.Empleado_Atiendes.Add(model);
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
                var resultado = _DbContext.Empleado_Atiendes.Find(id);
                _DbContext.Empleado_Atiendes.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
               

                throw;
            }
        }

        public Empleado_Atiende Get(int id)
        {
            try
            {
                var resultado = _DbContext.Empleado_Atiendes.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Empleado_Atiende> GetAll()
        {
            return _DbContext.Empleado_Atiendes.ToList();
        }

        public bool Update(Empleado_Atiende model)
        {
            try
            {
                var result = _DbContext.Empleado_Atiendes.Single(x =>
                 x.Id == model.Id);

                if (result == null)

                _DbContext.Empleado_Atiendes.Update(model);
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
