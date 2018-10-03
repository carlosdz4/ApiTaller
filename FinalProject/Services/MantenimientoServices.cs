using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class MantenimientoServices : ICrudService<Mantenimiento>
    {

        private readonly FinalProjectDbContext _DbContext;
        public MantenimientoServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public bool Add(Mantenimiento model)
        {
            try
            {
                _DbContext.Mantenimientos.Add(model);
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
                var resultado = _DbContext.Mantenimientos.Find(id);
                _DbContext.Mantenimientos.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;

                throw;
            }
        }

        public Mantenimiento Get(int id)
        {
            try
            {
                var resultado = _DbContext.Mantenimientos.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Mantenimiento> GetAll()
        {
            return _DbContext.Mantenimientos.ToList();
        }

        public bool Update(Mantenimiento model)
        {
            try
            {
                var result = _DbContext.Mantenimientos.Single(x =>
                 x.Id == model.Id);

                

                _DbContext.Mantenimientos.Update(model);
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
