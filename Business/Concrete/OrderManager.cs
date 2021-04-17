using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
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

        [TransactionScopeAspect]
        [CacheRemoveAspect("IOrderService.Get")]
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(OrderValidator))]
       public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        [TransactionScopeAspect]
        [CacheRemoveAspect("IOrderService.Get")]
        [SecuredOperation("product.add,admin")]
        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }
        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Order>> GetAll()
        {
            return new SuccesDataResult<List<Order>>(_orderDal.GetAll());
        }
        [CacheAspect]
        public IDataResult<List<Order>> GetById(int orderId)
        {
            return new SuccesDataResult<List<Order>>(_orderDal.GetAll(p=>p.OrderId==orderId));
        }

        [TransactionScopeAspect]
        [CacheRemoveAspect("IOrderService.Get")]
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(OrderValidator))]
        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUptaded);
        }
    }
}
