using System.ComponentModel.DataAnnotations;

namespace EF_Core.Dto
{
    public class AddStudentDto
    {
        public string Name { get; set; }
        [Range(7, 18)]
        public int Age { get; set; }
        public string Email { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
        public char Sex { get; set; }
    }
}
