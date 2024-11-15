using System.Collections.Generic;

namespace CSharpTrainingCamp301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int Id);
        List<T> GetAll();
        T GetById(int Id);
    }
}
