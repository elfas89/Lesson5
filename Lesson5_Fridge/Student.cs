using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Student
    {
        public string name;
        public int course;
        public int grants;

        public Student() { }
        public Student(string name, int course, int grants)
        {
            this.name = name;
            this.course = course;
            this.grants = grants;
        }

        public void Info()
        {
            Console.WriteLine("Студент " + name + ", курс " + course + ", размер стипендии " + grants);
        }
    }
}
