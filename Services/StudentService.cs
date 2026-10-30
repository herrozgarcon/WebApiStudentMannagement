using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class StudentService
{
    private StudentRepo StudentRepoObj;
    public StudentService(StudentRepo obj)
    {
        StudentRepoObj = obj;
    }


    public async Task AddStudent(Students student)
    {
        await StudentRepoObj.addasync(student);
    }
}