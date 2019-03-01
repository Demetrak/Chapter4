using System;
using System.Diagnostics.Tracing;


class Program
{
    static void Main()
    {
        //    5.Напишете програма, която чете от конзолата две цели числа(int) и отпечатва,
        //колко числа има между тях, такива, че остатъкът им от деленето на 5 да е 0.Пример: в интервала(17, 25) има 2 такива числа.
        int counter = 0;
        Console.Write("Enter a full number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second full number:");
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0) counter++;
        }

        Console.WriteLine("{0} number founds",counter);
    }

}

