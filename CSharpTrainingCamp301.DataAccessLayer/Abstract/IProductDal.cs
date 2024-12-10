using CSharpTrainingCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace CSharpTrainingCamp301.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Object> GetProductWithCategory();
    }
}
