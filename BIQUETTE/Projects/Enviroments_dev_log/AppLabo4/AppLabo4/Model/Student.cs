using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.Model
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name,int age)
        {
            Age = age;
            Name = name;
        }
    }
}
