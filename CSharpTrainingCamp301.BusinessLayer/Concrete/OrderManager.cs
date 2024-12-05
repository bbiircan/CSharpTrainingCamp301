using CSharpTrainingCamp301.BusinessLayer.Abstract;
using CSharpTrainingCamp301.DataAccessLayer.Abstract;
using CSharpTrainingCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace CSharpTrainingCamp301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order TGetById(int Id)
        {
            return _orderDal.GetById(Id);
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
