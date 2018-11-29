using System;
using System.Text;
using System.Threading.Tasks;
{
    
}
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
        intx;
        for(int i=0;ii<numbers.Lenght / 2;i++)
        {
            var index=numbers.Lenght-i-1;
            x=numbers[i];
            numbers[i]=numbers[index];
            numbers[index]=x;

           Swap(numbers,i,numbers.Lenght-i-1);
        }
        WriteNumbers(numbers);
        Console.ReadLine(;)
    }

public static void Swap(int[]arr,int i, intj)
{
    var x=arr[i];
    arr[i]=arr[j];
    arr[j]=x;
}


}