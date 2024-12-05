using CSharpTrainingCamp301.BusinessLayer.Abstract;
using CSharpTrainingCamp301.DataAccessLayer.Abstract;
using CSharpTrainingCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace CSharpTrainingCamp301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int Id)
        {
            return _customerDal.GetById(Id);
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
