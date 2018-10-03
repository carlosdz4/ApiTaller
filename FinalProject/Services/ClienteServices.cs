using Models;
using Persistence;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class ClienteServices : ICrudService<Cliente>
    {

        private readonly FinalProjectDbContext _DbContext;
        public ClienteServices(FinalProjectDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public bool Add(Cliente model)
        {
            try
            {
                _DbContext.Clientes.Add(model);
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
                var resultado = _DbContext.Clientes.Find(id);
                _DbContext.Clientes.Remove(resultado);
                _DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                

                throw;
            }
        }

        public Cliente Get(int id)
        {
            try
            {
                var resultado = _DbContext.Clientes.Find(id);


                return resultado;
            }
            catch (Exception)
            {
                throw;


            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _DbContext.Clientes.ToList();
        }

        public bool Update(Cliente model)
        {
            try
            {
                var result = _DbContext.Clientes.Single(x =>
                 x.Id == model.Id);

                if (result == null) 

                _DbContext.Clientes.Update(model);
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
