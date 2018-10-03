using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class DepartamentosServices : ICrudService<Departamentos>
    {

        private readonly FinalProjectDbContext _DbContext;
    public DepartamentosServices(FinalProjectDbContext dbContext)
    {
        _DbContext = dbContext;
    }

        public bool Add(Departamentos model)
        {
            try
            {
                _DbContext.Departamentos.Add(model);
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
                var resultado = _DbContext.Departamentos.Find(id);
                _DbContext.Departamentos.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                

                throw;
            }
        }

        public Departamentos Get(int id)
        {
            try
            {
                var resultado = _DbContext.Departamentos.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Departamentos> GetAll()
        {
            return _DbContext.Departamentos.ToList();
        }

        public bool Update(Departamentos model)
        {
            try
            {
                var result = _DbContext.Departamentos.Single(x =>
                 x.Id == model.Id);

                if (result == null) 

                _DbContext.Departamentos.Update(model);
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
