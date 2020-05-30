using System;
using System.Collections.Generic;
using Oicar.Dal;
using Oicar.Dal.Entities;
using Oicar.Dal.Interfaces;
using Oicar.Service.Interfaces;

namespace Oicar.Service.Services
{
    public class CloudNewsService : ICloudNewsService
    {
        private IUnitOfWork _uow;

        public CloudNewsService(OicarContext context)
        {
            _uow = new UnitOfWork(context);
        }

        public object Add(NewsPost entity)
        {
            try
            {
                _uow.News.Add(entity);
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

        public NewsPost Get(int id)
        {
            try
            {
                NewsPost result = _uow.News.Get(id);
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get by id", ex);
            }
        }

        public List<NewsPost> GetAll()
        {
            try
            {
                List<NewsPost> result = (List<NewsPost>)_uow.News.GetAll();
                if (result == null)
                    throw new Exception("Not found");

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get", ex);
            }
        }

        public object Remove(NewsPost entity)
        {
            try
            {
                _uow.News.Remove(entity);
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

        public object Update(NewsPost entity)
        {
            try
            {
                _uow.News.Update(entity);
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
