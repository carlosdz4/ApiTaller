using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class CitaServices : ICrudService<Cita>
    {

        private readonly FinalProjectDbContext _DbContext;
        public CitaServices( FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }


        public bool Add(Cita model)
        {
            try
            {
                _DbContext.Citas.Add(model);
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
                var resultado = _DbContext.Citas.Find(id);
                _DbContext.Citas.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                

                throw;
            }
       

        }

        public Cita Get(int id)
        {
            try
            {
                var resultado = _DbContext.Citas.Find(id);
                
                
                return resultado;
            }
            catch (Exception)
            {
                throw;

               
            }
        }

        public IEnumerable<Cita> GetAll()
        {
          return  _DbContext.Citas.ToList();
        }

        public bool Update(Cita model)
        {
            try
            {
                var result = _DbContext.Citas.Single(x =>
                 x.Id == model.Id);

                if (result == null) 

                _DbContext.Citas.Update(model);
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
