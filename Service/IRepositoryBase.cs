using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testprojectaspnetcore3_1.Service
{
  public  interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool isExists(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
