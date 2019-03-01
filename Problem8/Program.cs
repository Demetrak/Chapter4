using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        //8.Напишете програма, която чете пет числа от конзолата и отпечатва най - голямото от тях.
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        int e = int.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e) Console.WriteLine("The biggest number is {0}", a);
        else if (b > a && b > c && b > d && b > e) Console.WriteLine("The biggest number is {0}", b);
        else if (c > a && c > b && c > d && c > e) Console.WriteLine("The biggest number is {0}", c);
        else if (d > a && d > b && d > c && d > e) Console.WriteLine("The biggest number is {0}", d);
        else if (e > a && e > b && e > c && e > d) Console.WriteLine("The biggest number is {0}", e);
        else Console.WriteLine("There is not biggest number.");


           
           
            
        }







    }
}
