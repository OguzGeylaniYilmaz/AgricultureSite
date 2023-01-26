using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramewok
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
    }
}
