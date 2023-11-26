using System;
using System.Security.Cryptography;

namespace LAB6 { 

class HelloWorld
{
    public static void Main()
    {
        OrdinaryCalc standartCalculator = new();
        EngineerCalc engineerCalc = new ();

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Яку операцію ви хочете зробити");
        Console.WriteLine("1 Додавання");
        Console.WriteLine("2 віднімання");
        Console.WriteLine("3 Множення");
        Console.WriteLine("4 Ділення");
        Console.WriteLine("0 Вихід");
        Console.WriteLine("-----------------------------------------------");


        switch (Console.ReadLine())
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "0":
                break;
        }
    }
}
}