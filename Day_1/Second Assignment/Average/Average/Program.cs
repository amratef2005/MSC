decimal num1,num2,num3,average; 
Console.Write("Enter first number: ");
num1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter second number: ");
num2 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter third number: ");
num3 = Convert.ToDecimal(Console.ReadLine());
average = (num1 + num2 + num3) / 3;   
Console.WriteLine($"The average =  {average}\n");

