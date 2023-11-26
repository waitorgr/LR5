using System;
using System.Security.Cryptography;

namespace LAB6 { 

class HelloWorld
{
    public static void Main()
    {
        OrdinaryCalc standartCalculator = new OrdinaryCalc();
        EngineerCalc engineerCalc = new EngineerCalc();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Ведіть 1 число:");
                    standartCalculator.SetNum1(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Ведіть 2 число:");
                    standartCalculator.SetNum2(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Яку операцію ви хочете зробити");
                    Console.WriteLine("1 - Додавання");
                    Console.WriteLine("2 - віднімання");
                    Console.WriteLine("3 - Множення");
                    Console.WriteLine("4 - Ділення");
                    Console.WriteLine("0 - Вихід");
                    Console.WriteLine("-----------------------------------------------");


                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine(standartCalculator.Add());
                            break;
                        case "2":
                            Console.WriteLine(standartCalculator.Sub());
                            break;
                        case "3":
                            Console.WriteLine(standartCalculator.Mul());
                            break;
                        case "4":
                            Console.WriteLine(standartCalculator.Div());
                            break;
                        case "0":
                            Going = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Ведіть 1 число:");
                    standartCalculator.SetNum1(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Ведіть 2 число:");
                    standartCalculator.SetNum2(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Яку операцію ви хочете зробити");
                    Console.WriteLine("1 - Додавання");
                    Console.WriteLine("2 - віднімання");
                    Console.WriteLine("3 - Множення");
                    Console.WriteLine("4 - Ділення");
                    Console.WriteLine("5 - Експонента");
                    Console.WriteLine("0 - Вихід");
        Console.WriteLine("-----------------------------------------------");


        switch (Console.ReadLine())
        {
            case "1":
                            Console.WriteLine(engineerCalc.Add());
                break;
            case "2":
                            Console.WriteLine(engineerCalc.Sub());
                break;
            case "3":
                            Console.WriteLine(engineerCalc.Mul());
                break;
            case "4":
                            Console.WriteLine(engineerCalc.Div());
                            break;
                        case "5":
                            Console.WriteLine(engineerCalc.Exp());
                break;
            case "0":
                            Going = false;
                break;
        }
    }
}
}
}
}