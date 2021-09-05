using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TestProduct();

            //TestOrder();

           

        }

        private static void TestOrder()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetAll())
            {
                Console.WriteLine(order.CustomerId);
            }
        }

        private static void TestProduct()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine($"{product.ProductName} - {product.CategoryName}");
            }
        }
    }
}
