using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC E-Commerce System");

            var productList = new List<Product>();
            IECommerceModel eCommerceModel = new ECommerceModel(productList);

            while (true)
            {
                OptionMessage();
                Console.Write("Please Select an Option :");

                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    eCommerceModel.AddProduct();

                }
                else if (option == 2)
                {
                    eCommerceModel.DisplayProduct();
                }
                else if (option == 3)
                {
                    eCommerceModel.BuyProduct();
                }
                else if (option == 4)
                {
                    eCommerceModel.BoughtProduct();
                }
                else if (option == 5)
                {
                    eCommerceModel.TotalPrice();
                }
                else
                {
                    break;
                }
                Console.WriteLine("=========================================================");

            }
            Console.WriteLine("Thank You for using ABC E-Commerce System");
            Console.ReadKey();
        }
        public static void OptionMessage()
        {
            Console.WriteLine("1: Add Product to store");
            Console.WriteLine("2: Show Product list of store");
            Console.WriteLine("3: Buy Product");
            Console.WriteLine("4: Show all Bought Product list");
            Console.WriteLine("5: Show Total Price of all bought Product ");
            Console.WriteLine("6: Exit");
        }
    }
}
