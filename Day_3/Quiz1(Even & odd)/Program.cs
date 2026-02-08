Console.Write("Enter Number : ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num} is Even Number");
}
else
{
    Console.WriteLine($"{num} is Odd Number");
}