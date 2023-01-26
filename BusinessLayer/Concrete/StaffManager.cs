using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public List<Staff> GetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff GetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public void Insert(Staff t)
        {
            _staffDal.Insert(t);
        }
        public void Delete(Staff t)
        {
            _staffDal.Delete(t);
        }
        public void Update(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
