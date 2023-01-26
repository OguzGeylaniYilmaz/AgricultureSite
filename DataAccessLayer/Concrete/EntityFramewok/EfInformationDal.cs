using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramewok
{
    public class EfInformationDal : GenericRepository<Information>, IInformationDal
    {
        public void ChangeStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            Information information = context.Informations.Find(id);
            information.Status = false;
            context.SaveChanges();
        }

        public void ChangeStatusToTrue(int id)
        {
            using var context = new AgricultureContext();
            Information information = context.Informations.Find(id);
            information.Status = true;
            context.SaveChanges();
        }
    }
}
