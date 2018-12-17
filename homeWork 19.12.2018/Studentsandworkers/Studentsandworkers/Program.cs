using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentsandworkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("lastName 10", "firstName 1", 1));
            students.Add(new Student("lastName 9", "firstName 2", 3));
            students.Add(new Student("lastName 8", "firstName 3", 4));
            students.Add(new Student("lastName 7", "firstName 5", 2));
            students.Add(new Student("lastName 6", "firstName 4", 3));
            students.Add(new Student("lastName 5", "firstName 7", 1));
            students.Add(new Student("lastName 4", "firstName 6", 4));
            students.Add(new Student("lastName 3", "firstName 9", 3));
            students.Add(new Student("lastName 2", "firstName 8", 1));
            students.Add(new Student("lastName 1", "firstName 10", 1));

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("WlastName 10", "WfirstName 19",500, 8));
            workers.Add(new Worker("WlastName 9", "WfirstName 18", 800, 8));
            workers.Add(new Worker("WlastName 8", "WfirstName 17", 300, 2));
            workers.Add(new Worker("WlastName 7", "WfirstName 16", 400, 8));
            workers.Add(new Worker("WlastName 6", "WfirstName 15", 700, 6));
            workers.Add(new Worker("WlastName 5", "WfirstName 14", 200, 9));
            workers.Add(new Worker("WlastName 4", "WfirstName 13", 800, 7));
            workers.Add(new Worker("WlastName 3", "WfirstName 12", 500, 8));
            workers.Add(new Worker("WlastName 2", "WfirstName 11", 750, 8));
            workers.Add(new Worker("WlastName 1", "WfirstName 10", 625, 8));

           
            //// m-am blocat
            
        }
       
    }
}
