using EF_Core.Dto;
using EF_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Teacher/{id}")]
        public async Task<IActionResult> GetTeacher(int id)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Id == id);

            if (teacher == null)
                return NotFound($"Teacher with Id {id} not found.");

            return Ok(teacher);
        }

        [HttpPost("AddTeacher")]
        public async Task<IActionResult> AddTeacher([FromBody] AddTeacherDto teacherDto)
        {
            var teacher = new Teacher
            {
                Name = teacherDto.Name,
                Email = teacherDto.Email,
                Age = teacherDto.Age,
            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
            return Ok(teacher);
        }

        [HttpGet("Teachers")]
        public async Task<IActionResult> GetTeachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return Ok(teachers);
        }

        [HttpDelete("Teacher/{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Id == id);
            if (teacher == null)
                return NotFound("Teacher does not exist.");

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("Teacher/{id}")]
        public async Task<IActionResult> UpdateTeacher(int id, [FromBody] UpdateTeacherDto teacherDto)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Id == id);
            if (teacher == null)
                return NotFound("Teacher does not exist.");

            teacher.Name = teacherDto.Name;
            teacher.Email = teacherDto.Email;
            teacher.Age = teacherDto.Age;

            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
            return Ok(teacher);
        }
    }

    public class AddTeacherDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }

    public class UpdateTeacherDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}