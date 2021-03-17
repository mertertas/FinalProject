using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities

{
   public class Category:IDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
