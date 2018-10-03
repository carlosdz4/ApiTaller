using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class MecanicosServices: ICrudService<Mecanicos>
    {

        private readonly FinalProjectDbContext _DbContext;
        public MecanicosServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public bool Add(Mecanicos model)
        {
            try
            {
                _DbContext.Mecanicos.Add(model);
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
                var resultado = _DbContext.Mecanicos.Find(id);
                _DbContext.Mecanicos.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                

                throw;
            }
        }

        public Mecanicos Get(int id)
        {
            try
            {
                var resultado = _DbContext.Mecanicos.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Mecanicos> GetAll()
        {
            return _DbContext.Mecanicos.ToList();
        }

        public bool Update(Mecanicos model)
        {
            try
            {
                var result = _DbContext.Mecanicos.Single(x =>
                 x.Id == model.Id);

                if (result == null) 

                _DbContext.Mecanicos.Update(model);
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
