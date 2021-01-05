using Microsoft.EntityFrameworkCore;
using StudentenAPI.Models;

namespace StudentenAPI.Services
{
    public class APIDbContext:DbContext
    {

        public APIDbContext(DbContextOptions<APIDbContext> opt):base(opt){}

        public DbSet<Student> Students {get;set;}
        
    }
}