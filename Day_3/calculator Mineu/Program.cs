Console.WriteLine("Enter Tow Number :");
Console.Write("First Number:");
double num1=double.Parse(Console.ReadLine());
Console.Write("Second Number:");
double num2=double.Parse(Console.ReadLine());
int operationEnd=6;
do
{
    
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
            Console.WriteLine($"The Result Of Addition Is : {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"The Result Of Subtraction Is : {num1 - num2}");
            break;
        case 3:
            Console.WriteLine($"The Result Of Multiplication Is : {num1 * num2}");
            break;
        case 4:
            if (num2 != 0)
                Console.WriteLine($"The Result Of Division Is : {num1 / num2}");
            else
                Console.WriteLine("Cannot Divide By Zero");
            break;
        case 5:
            Console.WriteLine("Exiting...");
            operationEnd = 0;
            return;
        default:
            Console.WriteLine("Invalid Operation. Please Try Again.");
            break;
    }
} while (operationEnd!=0);
