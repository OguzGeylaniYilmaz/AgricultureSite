using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IInformationDal : IGenericDal<Information>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
    }
}
