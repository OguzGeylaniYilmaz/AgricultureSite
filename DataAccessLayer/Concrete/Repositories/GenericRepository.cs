using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {

        public List<T> GetAll()
        {
            using var context = new AgricultureContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new AgricultureContext();
            return context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var context = new AgricultureContext();
            context.Set<T>().Add(t);
            context.SaveChanges();
        }
        public void Delete(T t)
        {
            using var context = new AgricultureContext();
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }
        public void Update(T t)
        {
            using var context = new AgricultureContext();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }
    }
}
