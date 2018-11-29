using System;
namespace ConsoleApplication
{
    public class NumerePare
    {
        public  void Main()
        {
           var a=0;
           var b=1;
           int c=a+b;
           do
           {
               System.Console.WriteLine(c+",");
               c=a+b;
               a=b;
               b=c;
           }while(c<50);

           Console.ReadLine();
        }
    }
}