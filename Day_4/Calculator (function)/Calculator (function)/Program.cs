using System;

class Calculator
{
    // ========================================//
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot Divide By Zero");
            return double.NaN;
        }
        return a / b;
    }

    

 //======================================================================================//

    static void Main(string[] args)
    {
        Console.WriteLine("Enter Tow Number :");
        Console.Write("First Number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Second Number:");
        double num2 = double.Parse(Console.ReadLine());

        int operationEnd = 6;
        do
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter The Operation You Want To Do :");
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Division");
            Console.WriteLine("5-Exit");

            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"The Result Of Addition Is : {Add(num1, num2)}");
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine($"The Result Of Subtraction Is : {Subtract(num1, num2)}");
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Console.WriteLine($"The Result Of Multiplication Is : {Multiply(num1, num2)}");
                    Console.WriteLine("\n");
                    break;
                case 4:
                    double result = Divide(num1, num2);
                    if (!double.IsNaN(result))
                        Console.WriteLine($"The Result Of Division Is : {result}");
                    Console.WriteLine("\n");
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    Console.WriteLine();
                    operationEnd = 0;
                    return;
                default:
                    Console.WriteLine("Invalid Operation. Please Try Again.");
                    Console.WriteLine("\n");
                    break;
            }

        } while (operationEnd != 0);
    }
}