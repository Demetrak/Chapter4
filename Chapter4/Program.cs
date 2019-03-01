using System;

class Program
{
    static void Main()
    {
        //1.Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.

        Console.Write("Enter the value of 'a'");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of 'b'");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of 'c'");
        int c = int.Parse(Console.ReadLine());
        decimal sum = a + b + c;
        Console.WriteLine(sum);
    }
}
