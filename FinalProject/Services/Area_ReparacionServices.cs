using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class Area_ReparacionServices : ICrudService<Area_Reparacion>

    {


        private readonly FinalProjectDbContext _DbContext;
        public Area_ReparacionServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }


        public bool Add(Area_Reparacion model)
        {
            try
            {
                _DbContext.Area_Reparacions.Add(model);
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
                var resultado = _DbContext.Area_Reparacions.Find(id);
                _DbContext.Area_Reparacions.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
               

                throw;
            }
        }

        public Area_Reparacion Get(int id)
        {
            try
            {
                var resultado = _DbContext.Area_Reparacions.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Area_Reparacion> GetAll()
        {
            return _DbContext.Area_Reparacions.ToList();
        }

        public bool Update(Area_Reparacion model)
        {
            try
            {
                var result = _DbContext.Area_Reparacions.Single(x =>
                 x.Id == model.Id);

                if (result == null)

                _DbContext.Area_Reparacions.Update(model);
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
