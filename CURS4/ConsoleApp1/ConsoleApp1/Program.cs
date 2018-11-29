using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 17, 2, 7, 2, 8 };
            int value = 2;
            int index = 3;

            int[] newArray = new int[arr.Length + 1];

            int counter = 0;

            for(int i=0; i<=arr.Length;i++)
            {
                if (i==index)
                {
                    newArray[i] = value;
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i-counter];
                }
            }
            for(int i=0;i<newArray.Length;i++)
            {
                Console.WriteLine(newArray[i]+" ");
            }
        }
    }
}
