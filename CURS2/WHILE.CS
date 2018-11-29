using System;

namespace Curs2
{
    public class WhileExample
    {   
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
