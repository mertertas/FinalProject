﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Core.DataAccess.EntityFrameworkRepositoryBase;

namespace DataAccess.Concrete.EntityFramework

{
 public  class EfProductDal:EntityFrameworkRepositoryBase<Product,NorthwindContext>,IProductDal
    {
       
    }
}
