using Microsoft.EntityFrameworkCore;
using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class FacturaService : ICrudService<Factura>
    {
        private readonly FinalProjectDbContext _dbContext;

        public FacturaService(FinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Factura model)
        {
            try
            {
                _dbContext.Facturas.Add(model);
                _dbContext.SaveChanges();
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
                var result = _dbContext.Facturas.Find(id);

                if (result == null) 

                _dbContext.Facturas.Remove(result);
                _dbContext.SaveChanges();
                return true; 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Factura Get(int id)
        {
            try
            {
                var result = _dbContext.Facturas.Find(id);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Factura> GetAll()
        {
            return _dbContext.Facturas.ToList();
        }

        public bool Update(Factura model)
        {
            try
            {
                var result = _dbContext.Facturas.Single(x =>
                 x.Id == model.Id);

                if (result == null) 

                _dbContext.Facturas.Update(model);
                _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
