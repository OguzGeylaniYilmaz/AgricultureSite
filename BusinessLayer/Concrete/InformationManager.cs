using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class InformationManager : IInformationService
    {
        private readonly IInformationDal _informationDal;

        public InformationManager(IInformationDal informationDal)
        {
            _informationDal = informationDal;
        }
        public void Delete(Information t)
        {
            _informationDal.Delete(t);
        }

        public List<Information> GetAll()
        {
            return _informationDal.GetAll();
        }

        public Information GetById(int id)
        {
            return _informationDal.GetById(id);
        }

        public void Insert(Information t)
        {
            _informationDal.Insert(t);
        }

        public void Update(Information t)
        {
            _informationDal.Update(t);
        }
        public void ChangeStatusToFalse(int id)
        {
            _informationDal.ChangeStatusToFalse(id);
        }

        public void ChangeStatusToTrue(int id)
        {
            _informationDal.ChangeStatusToTrue(id);
        }
    }
}
