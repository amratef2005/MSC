using System;

class Program
{
    static void Main()
    {
        int user_age, required_age=18;

        Console.Write("Enter your age: ");
        user_age = Convert.ToInt32(Console.ReadLine());

        if (user_age >= required_age)
        {
            Console.WriteLine("You Are Eligible To Vote.");
        }
        else
        {
            Console.WriteLine("You Are Not Eligible To Vote.");
        }

    }

}
