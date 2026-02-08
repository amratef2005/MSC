Console.WriteLine("-> Highest value 4 <-");

Console.Write(("Enter Your GPA :"));
double GPA = double.Parse( Console.ReadLine());

if (GPA <= 4 && GPA >= 3)
{
    Console.WriteLine("The Estimate Of GPA is = [A+]");
}
else if (GPA < 3 && GPA >= 2)
{
    Console.WriteLine("The Estimate Of GPA is = [A]");
}
else if (GPA < 2 && GPA >= 1.5)
{
    Console.WriteLine("The Estimate Of GPA is = [B]");
}
else if (GPA < 1.5 && GPA > 0)
{
    Console.WriteLine("The Estimate Of GPA is = [c]");
}
else Console.WriteLine("Please enter the correct value\n");