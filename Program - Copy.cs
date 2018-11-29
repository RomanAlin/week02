using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicatii
{
    public static int FindINdex(int[] array, int value)
    {
        for(int i=0;i<array.Length;i++)
        {
            if (array[i]==value)
            {
                return i;
            }
        }
        return -1;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new[] { 5, 10, 15, 3 };
            int value = 3;
            var index = FindIndex(arr, value);
            Console.WriteLine(index);
            Console.ReadLine();
        }

        private static object FindIndex(int[] arr, int value)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            int[] arr=new[] { 5, 10, 15, 3};
            Double suma = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                suma = suma + arr[i];
            }
            double media = suma / arr.Length;
            Console.WriteLine(media);
            Console.WriteLine("text");

        }
    }
}
