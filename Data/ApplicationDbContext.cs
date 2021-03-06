using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subject { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<LearnerProfile> LearnerProfile { get; set; }
    }
}