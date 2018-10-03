using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class VehiculoServices : ICrudService<Vehiculo>
    {

        private readonly FinalProjectDbContext _DbContext;
        public VehiculoServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public bool Add(Vehiculo model)
        {
            try
            {
                _DbContext.Vehiculos.Add(model);
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
                var resultado = _DbContext.Vehiculos.Find(id);
                _DbContext.Vehiculos.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
               

                throw;
            }
        }

        public Vehiculo Get(int id)
        {
            try
            {
                var resultado = _DbContext.Vehiculos.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Vehiculo> GetAll()
        {
            return _DbContext.Vehiculos.ToList();
        }

        public bool Update(Vehiculo model)
        {
            try
            {
                var result = _DbContext.Vehiculos.Single(x =>
                 x.Id == model.Id);

                if (result == null)

                _DbContext.Vehiculos.Update(model);
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
