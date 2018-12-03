using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 =new [] { 1,5,19,4,22,10,7,99};
            var arr2 = new [] { 1, 5, 19,  22, 10,  99 };
            var common= arr1.Intersect(arr2);

           foreach(int element in common)
            {
                Console.WriteLine("elementele comune sunt: " + element);
            }
            
            
            
        }
    }
}
