using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICrudService<T> where T : new()
    {
        IEnumerable<T> GetAll();
        bool Add(T model);
        bool Delete(int id);
        bool Update(T model);
        T Get(int id);
    }
}
