using System;
using Oicar.Service.Interfaces;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Dal;
using System.Collections.Generic;

namespace Oicar.Service.Services
{
    public class CloudVMService : ICloudVMService
    {
        private IUnitOfWork _uow;

        public CloudVMService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public object Add(CloudVM entity)
        {
            try
            {
                _uow.CloudVM.Add(entity);
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

        public CloudVM Get(int id)
        {
            try
            {
                CloudVM result = _uow.CloudVM.Get(id);
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get by id", ex);
            }
        }

        public List<CloudVM> GetAll()
        {
            try
            {
                List<CloudVM> result = (List<CloudVM>)_uow.CloudVM.GetAll();
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get", ex);
            }
        }

        public object Remove(CloudVM entity)
        {
            try
            {
                _uow.CloudVM.Remove(entity);
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

        public object Update(CloudVM entity)
        {
            try
            {
                _uow.CloudVM.Update(entity);
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
