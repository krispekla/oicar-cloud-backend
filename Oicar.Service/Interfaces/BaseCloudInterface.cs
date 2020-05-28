using System.Collections.Generic;

namespace Oicar.Service.Interfaces
{
    public interface BaseCloudInterface<T>
    {
        T Get(int id);
        List<T> GetAll();
        object Add(T entity);
        object Remove(T entity);
        object Update(T entity);
    }
}
