using System;
using System.Collections.Generic;

namespace POSApplication.ForntEnd.Interface
{
    internal interface IBaseRepository<T> where T : class
    {
        int Save(T obj);
        int Update(T obj);
        int Delete(T obj);
        IList<T> GetAll();
    }
}
