namespace GenericMetod_Swap_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //SwapThenPrint(15 ,  25);
            SwapThenPrint("string" ,  "word");
            Console.ResetColor();
        }
        public static void SwapThenPrint<T>(  T a,  T b)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Before Swap ; {a} <<====>>{b}");
            T rem = a;
            a=b;
            b=rem;
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("After Swap : "+a+"   «»  "+b);
        }
       
    }
}
