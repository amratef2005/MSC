namespace EF_Core.Models
{
    public class Course
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public int Hour { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
