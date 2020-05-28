using System;
using System.Collections.Generic;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;

namespace Oicar.Service.Services
{
    public class CloudStorageService : ICloudStorageService
    {
        private IUnitOfWork _uow;

        public CloudStorageService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public object Add(CloudStorage entity)
        {
            try
            {
                _uow.CloudStorage.Add(entity);
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

        public CloudStorage Get(int id)
        {
            try
            {
                CloudStorage result = _uow.CloudStorage.Get(id);
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get by id", ex);
            }
        }

        public List<CloudStorage> GetAll()
        {
            try
            {
                List<CloudStorage> result = (List<CloudStorage>)_uow.CloudStorage.GetAll();
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get", ex);
            }
        }

        public object Remove(CloudStorage entity)
        {
            try
            {
                _uow.CloudStorage.Remove(entity);
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

        public object Update(CloudStorage entity)
        {
            try
            {
                _uow.CloudStorage.Update(entity);
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
