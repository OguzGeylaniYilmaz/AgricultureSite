using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void Insert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
