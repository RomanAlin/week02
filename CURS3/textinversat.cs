using System;
namespace ConsoleApplication
{
    public class NumerePare
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduceti sirul de caractere:");
            var s=Console.ReadLine();
            var arr=s.ToCharArray();
            for(var i=arr.Length-1;i>=0;i--)
            {
                System.Console.Write(arr(i));
            }
            //System.Console.WriteLine(s.Reverse());
            Console.ReadLine();
        }
    }
}