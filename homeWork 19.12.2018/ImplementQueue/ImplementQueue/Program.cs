using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("item 1");
            myQ.Enqueue("item 2");
            myQ.Enqueue("item 3");
            myQ.Enqueue("item 4");

            Console.WriteLine("Thea are {0} item in the Queue", myQ.Count);

            while (myQ.Count>0)
            {
                string str = (string)myQ.Dequeue();
                Console.WriteLine("Dequeueing object {0}", str);
            }

            Console.ReadLine();


        }   
    }
}
