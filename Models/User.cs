using Microsoft.AspNetCore.Identity;

namespace SchoolManagementSystem.Models
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        
        public List<Subject>? Subjects { get; set; }
    }
}
