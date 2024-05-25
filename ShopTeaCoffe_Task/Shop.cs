using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTeaCoffe_Task
{
    internal class Shop<T>: IDrinkShop<T> where T : Product
    {
        public double TotalIncome { get; private set; }
        private int capasity;
        private int count;
        public int Capasity { get=>capasity;}
        public int Count { get=>count;}
        private Product[] products; 
        public Shop()
        {
            products = new Product[0];
            capasity =products.Length;
        }

         public void AddProduct(T product)
         {
            if (!products.Any(p=>p?.Name.ToLower()==product.Name.ToLower()))
            {
                if (count == capasity)
                {
                    Array.Resize(ref products, capasity == 0 ? 4 : products.Length * 2);
                    capasity=products.Length;
                }
                products[count] = product;
                count++;    
            }
            else
            {
                Console.WriteLine("this product already exist");
            }
         }
        public void DisplayProducts()
        {
            if (count>0)
            {
                for (int i=0;i<count;i++)
                {
                    if (products[i]!=null)
                    {
                        Console.WriteLine($"Name : {products[i].Name} Price :  {products[i].Price}  Count : {products[i].Count}  " +
                         $"Type : {products[i].ToString()}");
                    }
                   
                }

            }
            else
            {
                Console.WriteLine(" Do not have any product ");

            }

        }
        public void SellProduct(string productName, int productQuantity) 
        {
            if (products.Any(p => p?.Name.ToLower()==productName.ToLower()))
            {
                for (int i=0; i<products.Length;i++)
                {
                    if (products[i]?.Name.ToLower()== productName.ToLower())
                    {
                        if (products[i].Count >= productQuantity)
                        {
                            products[i].Count -= productQuantity;
                            TotalIncome +=(double) (productQuantity * products[i].Price);

                            if (products[i].Count==0)
                            {
                                products[i] = products[count - 1];
                                products[count - 1] = null;
                                count--;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine(" not enought  product in stock ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("product not found");
            }
        }

        public void ShowIncome()
        {
            Console.WriteLine($"TotalIncome : {TotalIncome}");
        }

    }
}
