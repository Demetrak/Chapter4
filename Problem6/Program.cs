using System;

class Program
{
    static void Main()
    {
        //6.Напишете програма,която чете две числа от конзолата и отпечатва по - голямото от тях.
        //Решете задачата без да използвате условни конструкции.
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a,b));
        Console.WriteLine(Math.Min(a,b));

    }
}
