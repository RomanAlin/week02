using System;
namespace  Curs3
{
    class Program
    {
        static void Main(string[] args)
        int[] numbers=new int[5];
        numbers[0]=10;
        numbers[1]=11;
        numbers[2]=13;
        numbers[3]=14;
        numbers[4]=15;
        for(int i=numbers.Lenght-1;i>=0;i++)
        {
            if(i==0)
            {
                System.Console.WriteLine(numbers(i));
            }
            else
            {
            System.Console.WriteLine(numbers[i]+" ");
                 }
        }
        Console.ReadLine(;)
    }

}