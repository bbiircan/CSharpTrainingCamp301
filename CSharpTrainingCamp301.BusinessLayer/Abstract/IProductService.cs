using CSharpTrainingCamp301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CSharpTrainingCamp301.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductWithCategory();

    }
}
