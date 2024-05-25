using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTeaCoffe_Task
{
    internal interface IDrinkShop<T> where T : Product
    {
      void   AddProduct(T product);
      void DisplayProducts();
      void SellProduct(string productName, int productQuantity);
      void ShowIncome();

    }
}
