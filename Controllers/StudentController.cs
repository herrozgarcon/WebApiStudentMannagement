using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : Controller
{
    
    private readonly StudentService _studentService;

    public StudentController(StudentService studentService)
    {
        _studentService = studentService;
    }


    [HttpGet]
    public async Task<ActionResult<List<Students>>> DisplayStudents()
    {
        var students = await _studentService.GetAllStudents();

        return Ok(students);
    }
    
    
    // POST: api/students
    [HttpPost]
    public async Task<IActionResult> AddStudent(CreateStudentDto studentDto)
    {
        var student = new Students
        {
            StudentName = studentDto.StudentName,
            BloodGroup = studentDto.BloodGroup,
            Email = studentDto.Email,
            Age = studentDto.Age
        };
    
        await _studentService.AddStudent(student);
    
        return Ok(new
        {
            message = "Student created successfully",
            student
        });
    }
}