using CSharpTrainingCamp301.DataAccessLayer.Abstract;
using CSharpTrainingCamp301.DataAccessLayer.Repositories;
using CSharpTrainingCamp301.EntityLayer.Concrete;

namespace CSharpTrainingCamp301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product> , IProductDal
    {
    }
}
