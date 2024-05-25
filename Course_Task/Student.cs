using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Task
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string PIN { get; set; }
        public Student(string name,string surName,int age,string pin)
        {
            Name = name;
            SurName = surName;
            Age = age;
            PIN = pin;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Student Name : {Name}\n" +
                  $" Student Surname : {SurName}\n" +
                  $" Student Age :  {Age}\n" +
                  $" PIN :  {PIN}");
        }
    }
}
