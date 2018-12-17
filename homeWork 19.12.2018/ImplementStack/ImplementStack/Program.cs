using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("item 1");
            myStack.Push("item 2");
            myStack.Push("item 3");

            
            Console.WriteLine("myStack \tCount: {0}", myStack.Count);
            Console.Write("\tValues:");

            PrintValues(myStack);
             void PrintValues(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)
                    Console.Write("    {0}", obj);
                Console.WriteLine();
            }
            Console.WriteLine("(Peek)primul element \t\t{0}", myStack.Peek());//afiseaza primul element din stack

            Console.WriteLine("(Pop)elementul eliminat \t\t{0}", myStack.Pop()); // afiseaza elementul eliminat - fiind primul

            myStack.Push("item 4");
            myStack.Push("item 5");
            Console.WriteLine("au mai ramas \tCount:    {0}", myStack.Count);//numarul de elemente din Stack dupa Eliminarea "!"
            PrintValues(myStack);
        }

    }
}

