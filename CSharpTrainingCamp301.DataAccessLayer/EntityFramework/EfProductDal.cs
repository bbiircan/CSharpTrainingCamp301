using CSharpTrainingCamp301.DataAccessLayer.Abstract;
using CSharpTrainingCamp301.DataAccessLayer.Context;
using CSharpTrainingCamp301.DataAccessLayer.Repositories;
using CSharpTrainingCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTrainingCamp301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductWithCategory()
        {
            var context = new CampContext();
            var values = context.Products.Select(x => new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName
            }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
