namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Developer developer = new Developer();
            developer.Name = "Amr Atef";
            developer.Salary = 30000;
            developer.ProgrammingLanguage = "C#,SQL";
            developer.Work("Developer");

            Console.WriteLine("|====+=====+====+====+====+====+====+====+====+====+====|\n");

            Manager manager = new Manager();
            manager.Name = "Kareem Magdy";
            manager.Salary = 50000;
            manager.TeamSize = 10; 
            manager.Work("Manager");

            
            
           
        }
    }
}
