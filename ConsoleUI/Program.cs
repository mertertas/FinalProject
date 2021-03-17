using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console UI Started!");
            //ProductTest();
            //CategoryTest();

            ProductDetailTest();

            Console.ReadLine();

        }

        private static void ProductDetailTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }

        private static void CategoryTest()
        {
            ICategoryService categoryService = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryService.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            IProductService productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(20, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
