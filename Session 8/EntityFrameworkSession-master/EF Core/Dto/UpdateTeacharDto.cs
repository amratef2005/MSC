using EF_Core.Models;
using System.ComponentModel.DataAnnotations;

namespace EF_Core.Dto
{
    public class UpdateTeacharDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
