using System;
using System.Collections.Generic;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;

namespace Oicar.Service.Services
{
    public class CloudFunctionService : ICloudFunctionService
    {
        private IUnitOfWork _uow;

        public CloudFunctionService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public object Add(CloudFunction entity)
        {
            try
            {
                _uow.CloudFunction.Add(entity);
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

        public CloudFunction Get(int id)
        {
            try
            {
             CloudFunction result = _uow.CloudFunction.Get(id);
                if (result == null)
                  throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get by id", ex);
            }
        }

        public List<CloudFunction> GetAll()
        {
            try
            {
               List<CloudFunction> result = (List<CloudFunction>)_uow.CloudFunction.GetAll();
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get", ex);
            }
        }

        public object Remove(CloudFunction entity)
        {
            try
            {
                _uow.CloudFunction.Remove(entity);
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

        public object Update(CloudFunction entity)
        {
            try
            {
                _uow.CloudFunction.Update(entity);
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
