using EF_Core.Dto;
using EF_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost("AddStudent")]
        public async  Task<IActionResult> AddStudent([FromBody] AddStudentDto studentDto)
        {
            var Student = new Student
            { 
                Name = studentDto.Name,
                Email = studentDto.Email,
                Age = studentDto.Age,
                Phone = studentDto.Phone,   
                Sex = studentDto.Sex,

            };

            await _context.Teachars.AddAsync(Student);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("Studets")]
        public async Task<IActionResult> Students()
        {
            var students  = await _context.Teachars.ToListAsync();
            return Ok(students);
        }
        [HttpGet("Student{Id}")]
        public async Task<IActionResult> Student(int Id)
        {
            var student = await _context.Teachars.FirstOrDefaultAsync(s => s.Id == Id);
            return Ok(student);
        }
        [HttpDelete("Student")]
        public async Task<IActionResult> DeleteStudent(int Id)
        {
            var StudentExist = await _context.Teachars.FirstOrDefaultAsync(s => s.Id == Id);
            if (StudentExist == null)
                return NotFound("Student Not Exist");
            _context.Teachars.Remove(StudentExist);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent(int Id, [FromBody] UpdateStudentDto studentDto)
        {
            var StudentExist = await _context.Teachars.FirstOrDefaultAsync(s => s.Id == Id);
            if (StudentExist == null)
                return NotFound("Student Not Exist");
            StudentExist.Name = studentDto.Name;
            StudentExist.Email = studentDto.Email;  
            StudentExist.Phone = studentDto.Phone;      
            StudentExist.Sex = studentDto.Sex;  
            StudentExist.Age = studentDto.Age;

            _context.Teachars.Update(StudentExist);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
