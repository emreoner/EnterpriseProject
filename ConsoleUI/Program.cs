using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productService.GetProductDetails();
            if (result.Success)
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + ":" + item.CategoryName);
                }
            else
                Console.WriteLine(result.Message);

        }
    }
}
