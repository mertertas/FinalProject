using Core.DataAccess.EntityFrameworkRepositoryBase;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
   public class EfOrderDal:EntityFrameworkRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}
