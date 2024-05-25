namespace Course_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

           
            while (true)
            {
            
                DisplayMenu();
                int chooseOption = Convert.ToInt32(Console.ReadLine());

                switch (chooseOption)
                {
                    case 1:
                         AddSTudent(course);
                        break;
                    case 2:
                        Console.WriteLine(" choose Remove Student PIN : ");
                        string removePIN = Console.ReadLine();
                        course.RemoveStudent(removePIN);
                        break;
                    case 3:
                        course.DisplayAllStudents();
                        Console.WriteLine("-----------");
                        break;
                    case 4:
                    SearchStudent: Console.WriteLine(" you can search student with 2 method : 1 - with name and surname ;" +
                       " 2 - with Student PIN;\n choose one");
                        int chooseSearchStudentOption = Convert.ToInt32(Console.ReadLine());
                        switch (chooseSearchStudentOption)
                        {
                            case 1:
                                Console.WriteLine("enter  name");
                                string searchingName = Console.ReadLine();

                                Console.WriteLine("enter  surname");
                                string searchingSurName = Console.ReadLine();
                                course.SearchStudentWithNameAndSurname(searchingName, searchingSurName);
                                break;
                            case 2:
                                Console.WriteLine("enter student PIN ");
                                string searchingPIN = Console.ReadLine();
                                course.SearchStudentWithPIN(searchingPIN);
                                break;
                            default:
                                Console.WriteLine(" invalid choose");
                                goto SearchStudent;
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Total Student Count {course.TotalStudentCount()}");
                        break;
                    case 6:
                        Console.WriteLine("Total student count (Age Greater 18) : " + course.TotalStudentCountWhereAgeGreater18());
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("invalid choose");
                        break;

                }
            }
        }

        static  private void DisplayMenu()
        {
            Console.Write("Choose an option: \n " +
               " 1 - Add a new Student \n" +
               " 2- Remove a student \n " +
               " 3 - Display all students \n " +
               " 4 - Search for a student \n " +
               " 5 - Count total students \n " +
               " 6 -  Total Student Count Where Age Greater18 \n" +
               " 7 - Exit \n ");
        }

        static private void AddSTudent( Course course)
        {
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();

            Console.WriteLine("enter student surname");
            string surName = Console.ReadLine();

            Console.WriteLine("enter student age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter student PIN");
            string pin = Console.ReadLine();
            if( CheckLength(name,surName,pin))
            {
                if (name.Contains(" ") || surName.Contains(" ") || pin.Contains(" "))
                {
                    name = name.Replace(" ", "");
                    surName = surName.Replace(" ", "");
                    pin = pin.Replace(" ", "");
                }
                course.AddStudent(new Student(name, surName, age, pin));
            }
            else
            {
                Console.WriteLine("wroong");
            }
        }

        private static bool CheckLength(string name,string surName ,string pin)
        {
            if (name.Replace(" ","").Length>=3 && surName.Replace(" ","").Length>=3 && pin.Replace(" ", "").Length>6)
            {
                return true;
            }
            return false;
        }

    }
}
