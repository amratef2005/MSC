using System.ComponentModel.DataAnnotations;

namespace EF_Core.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(7, 18)]
        public int Age { get; set; }
        public string Email { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        public char Sex { get; set; }
        public ICollection<Course> Courses { get; set; }
    }

}