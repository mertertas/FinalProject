using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccesDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetById(int orderId)
        {
            return new SuccesDataResult<List<Order>>(_orderDal.GetAll(p=>p.OrderId==orderId));
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUptaded);
        }
    }
}
