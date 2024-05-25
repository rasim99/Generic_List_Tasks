namespace ShopTeaCoffe_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop<Product> product = new Shop<Product>();
          while (true)
            {
                DisplayMenu();
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AddProduct(product);
                        break;
                    case 2:
                        SellProduct(product);
                        break;
                    case 3:
                        product.DisplayProducts();
                        break;
                    case 4:
                        product.ShowIncome();
                        break;
                        case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choosing");
                        break;
                }
            }
           

        }
        static void DisplayMenu()
        {
            Console.WriteLine("Choose one : \n 1- Add Product  \n  2- Sell Product  " +
                "\n 3-Display Products \n 4- Show TotalIncome \n 5 -Exit");
        }

        static void AddProduct(Shop<Product>shop)
        {
            Console.WriteLine("Enter product type(c --> coffee , t --> tea)");
            char productType = Convert.ToChar(Console.ReadLine());
             if(productType !='t'&&  productType!='c')
            {
                Console.WriteLine("wrong! only t or c char");
                return;
            }
            Console.WriteLine("enter product name ");
            string productName = Console.ReadLine();
           
            if (productName.Replace(" ", "").Length <4)
            {
                Console.WriteLine("please enter miniumum 4 character");
                return;
            }
            Console.WriteLine("enter product count");
            int productCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product price");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            if (productType=='t')
            {
                shop.AddProduct(new Tea(productName.Replace(" ",""),productCount,productPrice));
            }
            else if(productType=='c')
            {
                shop.AddProduct(new Coffee(productName.Replace(" ",""), productCount, productPrice));
            }
        }

        static void SellProduct(Shop<Product> product)
        {
            Console.WriteLine("enter product name for sell");
            string productName=Console.ReadLine();
            Console.WriteLine("enter product quantity for sell");
            int productQuantity = Convert.ToInt32(Console.ReadLine());
            product.SellProduct(productName, productQuantity);

        }
    }
}
