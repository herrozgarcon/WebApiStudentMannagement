using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs;

public class CreateStudentDto
{
    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string StudentName { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string BloodGroup { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    
    [Range(17, 30)]
    public int Age { get; set; }
    
}