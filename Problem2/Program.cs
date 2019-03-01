using System;

class Program
{
    static void Main()
    {
        //2.Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговия периметър и обиколка.
        Console.Write("Enter the value of r= ");
        double r = double.Parse(Console.ReadLine());
        double p = 2 * Math.PI * r;
        double s = Math.PI * r * r;
        Console.WriteLine(p);
        Console.WriteLine(s);

    }

}
