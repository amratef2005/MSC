namespace EF_Core.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }  
        public ICollection<Course> Courses { get; set; }
    }
}
