using System;

class Program
{
    static void Main()
    {
 //3.Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер.
        //Напишете програма, която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.
        Console.Write("Enter company name:");
        string compName = Console.ReadLine();
        Console.Write("Enter adrress: ");
        string address = Console.ReadLine();
        Console.Write("Enter the telephone:");
        string phone = Console.ReadLine();
        Console.Write("Enter the fax number: ");
        string faxNum = Console.ReadLine();
        Console.Write("enter the web: ");
        string wed = Console.ReadLine();
        Console.Write("Enter the name of manager: ");
        string nameMan = Console.ReadLine();
        Console.Write("Enter the last name of manager: ");
        string lastName = Console.ReadLine();
        Console.Write("enter the phone of manager: ");
        string phoneMan = Console.ReadLine();
        Console.WriteLine("Company: Name - {0},Address - {1},Phone - {2},Fax - {3},Wed - {4}",compName,address,phone,faxNum,wed);
        Console.WriteLine("manager: Name - {0,Last Name - {1},Phone - {2}",nameMan,lastName,phoneMan);
    }
}
