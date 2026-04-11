using System;

class employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public void Work(string work)
    {
        Console.WriteLine($"Hello {Name} is Salary= {Salary} is Working: {work}.\n");
    }
}
