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

}