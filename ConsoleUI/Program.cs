using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console UI Started!");

            IProductService productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(20, 100))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();

        }
    }
}
