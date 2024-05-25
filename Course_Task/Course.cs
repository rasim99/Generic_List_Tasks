using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Task
{
    internal class Course
    {
        private List<Student> students;
        public Course()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            if (!students.Any(s=>s.PIN==student.PIN))
            {
                
                    students.Add(student);
            }
            else
            {
                Console.WriteLine("cannot add!");
            }
        }
        public void RemoveStudent(string studentPIN)
        {
            Student student=students.FirstOrDefault(s=>s.PIN==studentPIN);
            if (student!=null)
            {
                students.Remove(student);
            }
            else
            {
                Console.WriteLine("dont have that student");
            }
        }
        public void DisplayAllStudents()
        {
            if (students.Count!=0)
            {
                foreach (var student in students)
                {
                    student.GetDetails();
                }
            }
            else
            {
                Console.WriteLine("have not studnets in the list");
            }
           
        }

        public void SearchStudentWithNameAndSurname(string name,string surName)
        {
            var  student=students.FirstOrDefault(s=>s.Name==name && s.SurName==surName);
            if (student != null)
            {
                student.GetDetails();
            }
            else
            {
                Console.WriteLine(" not found student");

            }
        }
        
        public void SearchStudentWithPIN(string searchingPIN)
        {
            var  student=students.FirstOrDefault(s=>s.PIN == searchingPIN);
            if (student != null)
            {
                student.GetDetails();
            }
            else
            {
                Console.WriteLine(" not found student");

            }
        }

        public int TotalStudentCount()
        {
            return students.Count;
        }
        public int TotalStudentCountWhereAgeGreater18()
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.Age>18)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
