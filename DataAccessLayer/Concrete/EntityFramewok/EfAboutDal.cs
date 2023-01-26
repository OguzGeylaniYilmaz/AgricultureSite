using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramewok
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
