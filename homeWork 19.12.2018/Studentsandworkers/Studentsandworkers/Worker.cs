using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentsandworkers
{
    class Worker:Human
    {
        public Worker(string lastName, string firstName, decimal weekSalary, int workHoursPerDay)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;

        }
        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return WeekSalary / 7 / WorkHoursPerDay;

        }
        
        public new void Print()
        {
            Console.WriteLine($" {WeekSalary}lei / Week {WorkHoursPerDay} ore pe zi {this.MoneyPerHour()} lei / ora");
        }
        

    }
}
