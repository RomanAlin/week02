using System;
namespace ConsoleApplication

{
    public class GuessNumber
    {
        static void Main(string[] args)
        {       
            var numberToGuess=new Random().Next(1,10);
          bool ok=false;

           while(true)
           {
                var x= Convert.ToInt32(Console.ReadLine()) ;

                if(x==numberToGuess)
                {
                    System.Console.WriteLine("Felicitari !Ati ghicit numarul");
                    break;
                }
                
                    System.Console.WriteLine((x<numberToGuess)
                    ?"Numarul introdus este prea mic"
                    : "Numarul introdus este prea");
                    // if(x<numberToGuess)
                    // {
                    //     System.Console.WriteLine("Numarul introdus este mai mic");
                    // }
                    // else
                    // {
                    //     System.Console.WriteLine("Numarul introdus este prea mare");
                    // }
                    // System.Console.WriteLine("Mai incearca!");
                
           }
           Console.ReadLine();
        }
        
    }

}