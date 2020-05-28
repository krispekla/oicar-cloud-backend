using System.Collections.Generic;

namespace Oicar.Service.Interfaces
{
    public interface BaseCloudInterface<TEntity>
    {
        TEntity Get(int id);
        List<TEntity> GetAll();
        object Add(TEntity entity);
        object Remove(TEntity entity);
        object Update(TEntity entity);
    }
}
