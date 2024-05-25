using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Task
{
    internal class GroupList
    {
        private List<Group> groupList = new List<Group>();
        public void AddGroup(Group group)
        {
            if (!groupList.Any(g => g.Name == group.Name))
            {
                groupList.Add(group);
                Console.WriteLine($"{group.Name} ugurla elave edildi");
            }
            else
            {
                Console.WriteLine($"{group.Name} artiq elave olunmusdur");
            }
        }

        public void GetAllGroup()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Listdeki movcud qruplar  :");
            foreach (var group in groupList)
            {
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine(group.Name);
            }
            Console.ResetColor();

        }
    }
}
