using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystem
{
    interface IECommerceModel
    {
        void AddProduct();
        void DisplayProduct();
        void BuyProduct();
        void BoughtProduct();
        void TotalPrice();
    }
}
