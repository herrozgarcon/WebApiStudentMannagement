using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Repositories;

public class StudentRepo
{
    private readonly AppDbContext _dbContext;
    public StudentRepo(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task addasync(Students student)
    {
        await _dbContext.Students.AddAsync(student);
        
        await _dbContext.SaveChangesAsync();
        
    }

    public async Task<List<Students>> displayStudents()
    {
         var studentlist= await _dbContext.Students.ToListAsync();
         return studentlist;
    }
    
    // GET: Retrieve student by ID
    public async Task<Students>? GetStudentById(int id)
    {
        return await _dbContext.Students.FirstOrDefaultAsync(s => s.StudentsId == id);
    }

}