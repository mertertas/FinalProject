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
            //ProductDetailTest();

            //ProductGetAllTest();

            Console.ReadLine();

        }

        //private static void ProductGetAllTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    var result = productManager.GetAll();

        //    if (result.Success)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }

        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        private static void ProductDetailTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal())) ;
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }

        //private static void CategoryTest()
        //{
        //    ICategoryService categoryService = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryService.GetAll().Data)
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    IProductService productManager = new ProductManager(new EfProductDal());
        //    foreach (var product in productManager.GetByUnitPrice(20, 100).Data)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}
    }
}
