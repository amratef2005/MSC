using EF_Core.Models;

namespace EF_Core.Dto
{
    public class AddTeacharDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
