using System;
using System.Collections.Generic;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;

namespace Oicar.Service.Services
{
    public class DbSQLService : IDbSQLService
    {
        private IUnitOfWork _uow;

        public DbSQLService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public object Add(CloudDbSQL entity)
        {
            try
            {
                _uow.CloudDbSQL.Add(entity);
                _uow.Complete();
                return new { message = "Succesfully added" };
            }
            catch (Exception ex)
            {
                throw new Exception("Failed at adding new object", ex);
            }
            finally
            {
                _uow.Dispose();
            }
        }

        public CloudDbSQL Get(int id)
        {
            try
            {
                CloudDbSQL result = _uow.CloudDbSQL.Get(id);
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get by id", ex);
            }
        }

        public List<CloudDbSQL> GetAll()
        {
            try
            {
                List<CloudDbSQL> result = (List<CloudDbSQL>)_uow.CloudDbSQL.GetAll();
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get", ex);
            }
        }

        public object Remove(CloudDbSQL entity)
        {
            try
            {
                _uow.CloudDbSQL.Remove(entity);
                _uow.Complete();
                return new { message = "Succesfully removed" };
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to remove", ex);
            }
            finally
            {
                _uow.Dispose();
            }
        }

        public object Update(CloudDbSQL entity)
        {
            try
            {
                _uow.CloudDbSQL.Update(entity);
                _uow.Complete();
                return new { message = "Succesfully updated" };
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update", ex);
            }
            finally
            {
                _uow.Dispose();
            }
        }
    }
}
