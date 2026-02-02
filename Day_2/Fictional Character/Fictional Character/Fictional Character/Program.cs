using System;

class Program
{
    static void Main()
    {
        string Name, favorite_hobby;
        int age;
        bool is_student=true ;
        Console.WriteLine(@"Enter Your Name :");
        Name=Console.ReadLine();
        Console.WriteLine(@"Enter Your Age :");
        age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(@"Enter Your Favorite Hobby :");
        favorite_hobby=Console.ReadLine();
        Console.WriteLine("Are you a student?(True / False)");
        is_student=Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine($"\"Hi, my name is {Name}. I am {age} years old and it is {is_student} that I am a student. My favorite hobby is {favorite_hobby}!\"");

       

    }
}