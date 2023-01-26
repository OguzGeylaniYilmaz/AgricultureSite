using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IInformationService : IGenericService<Information>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
    }
}
