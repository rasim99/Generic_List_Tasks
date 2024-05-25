using System.Xml.Schema;

namespace Generic_List_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Remove(3);
            list.Remove(3);
            list.Remove(1);
            list.Remove(5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Contains_Element =======>>  "+list.Contains(2) );
            //list.Clear();
            Console.WriteLine($"List Capasity ===>> {list.Capasity}  \n List Element Count===>>{list.Count}");
            list.GetAll();
            Console.WriteLine($"FirstOrDefault ==>> {list.FirstOrDefault()}");
            Console.WriteLine("ElementAtOrDefault ==>> "+list.ElementAtOrDefault(1));
            Console.WriteLine($"LastOrDefault ==>> {list.LastOrDefault()}");
            Console.ResetColor();
        }
    }
}
