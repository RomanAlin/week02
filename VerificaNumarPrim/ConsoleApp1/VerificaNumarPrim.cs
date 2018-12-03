using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerificaNumarPrim
    {
        static void Main(string[] args)

        {                       
            Console.WriteLine("Introduceti numarul dorit");
            var temp1 = Console.ReadLine();
            int a = Convert.ToInt32(temp1);
            

            var numbers = new[]{ 2, 3};
           
                if ((a % 2 == 0 || a % 3 == 0))
                    {
                        for (int i = a; i <= 3; i++)
                        {
                            if (a % 2 == 0 || a % 3 == 0)
                            {
                                Console.WriteLine("Nmarul " + a + " ESTE numar prim;");
                                break;
                            }
                       
                        }

                    }                 
                
                             else
                    {
                        Console.WriteLine("Nmarul " + a + " ESTE numar prim;");
                    }

          

        }

     }
                
   }
  

