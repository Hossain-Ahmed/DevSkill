using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem
{
    class ECommerceModel : IECommerceModel
    {
        private List<Product> productList;
        public ECommerceModel(List<Product> productList)
        {
            this.productList = productList;
        }
        public void AddProduct()
        {

            Console.Write("Enter Product Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Quantity: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product b = new Product(code, name, price, stock);
            productList.Add(b);
            Console.WriteLine("Successfully Product Added");
        }
        public void DisplayProduct()
        {
            var table = new ConsoleTable("Code", "Name", "Price", " Remainning Stock");

            foreach (var item in productList)
            {
                table.AddRow(item.Code, item.Name, item.Price, item.Stock);
            }
            table.Write();
        }
        public void BuyProduct()
        {
            Console.Write("Enter Product Code: ");
            string buyCode = Console.ReadLine();

            Product searchProduct = productList.Where(x => x.Code == buyCode).FirstOrDefault();
            if (searchProduct != null)
            {
                Console.Write("Enter Product Quantity: ");
                int buyStock = Convert.ToInt32(Console.ReadLine());

                if (searchProduct.Stock >= buyStock)
                {
                    searchProduct.BuyProduct(buyStock);
                   
                    Console.WriteLine("Successfully Product Bought!!!!!");
                }
                else
                {
                    Console.WriteLine("Sorry given quantity is not available on stock");
                }

            }
            else
            {
                Console.WriteLine("Product not Found");
            }

        }
        public void BoughtProduct()
        {
            

        }
       public void TotalPrice()
        {
           
        }
        

    }
}
