using System;

namespace Curs2
{
    public class ThrowExample
    {   
        public static void Main()
        {
           int i=100;
           while(i>0)
           {
               i--;
               if(i%7==0)
               {
                  throw new Exception("it`s over");
               }
               Console.WriteLine(i);
               Console.WriteLine(i);
           }
           Console.WriteLine("done");
        }
    }
}
