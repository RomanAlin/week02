using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentsandworkers
{
    class Student:Human
    {
        public int Grade { get; set; }

        public Student(string lastName, string firstName, int grade)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Grade = grade;
        }
        public new void Print()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName}{this.Grade}");
        }
       
       


    }
    
}
