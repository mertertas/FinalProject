using Core.DataAccess.EntityFrameworkRepositoryBase;
using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EntityFrameworkRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
        
    }
}
