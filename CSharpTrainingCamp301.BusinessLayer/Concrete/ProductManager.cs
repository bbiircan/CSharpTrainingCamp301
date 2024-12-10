﻿using CSharpTrainingCamp301.BusinessLayer.Abstract;
using CSharpTrainingCamp301.DataAccessLayer.Abstract;
using CSharpTrainingCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace CSharpTrainingCamp301.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int Id)
        {
            return _productDal.GetById(Id);
        }

        public List<Object> TGetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
