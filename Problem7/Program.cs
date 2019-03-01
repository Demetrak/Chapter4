using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        //7.Напишете програма,която чете пет числа и отпечатва тяхната сума. 
        //При невалидно въведено число да се подкани потребителя да въведе друго число.
        int a, b, c, d, e;
        bool parseSucceed = false;
        do
        {
            Console.Write("Enter the first number:");
            parseSucceed = Int32.TryParse(Console.ReadLine(),out a);
            Console.WriteLine(parseSucceed);
        } while (!parseSucceed);

        do
        {
            Console.Write("Enter the second number: ");
            parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine(parseSucceed);
        } while (!parseSucceed);

        do
        {
            Console.Write("Enter the third number: ");
            parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
            Console.WriteLine(parseSucceed);
        } while (!parseSucceed);

        do
        {
            Console.Write("Enter the fourth number: ");
            parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
            Console.WriteLine(parseSucceed);
        } while (!parseSucceed);

        do
        {
            Console.Write("Enter the fifth number:");
            parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
            Console.WriteLine(parseSucceed);
        } while (!parseSucceed);

        Console.WriteLine(a+b+c+d+e);
    }
}
