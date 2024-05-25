namespace Group_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("Pb401");
            Group group2 = new Group("A777");
           GroupList groupList = new GroupList();
           
            groupList.AddGroup( group);
            groupList.AddGroup( group);
            groupList.AddGroup( group2);
            groupList.GetAllGroup();
        }
        
    }
}
