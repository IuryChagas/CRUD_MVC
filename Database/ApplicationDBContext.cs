using Microsoft.EntityFrameworkCore;
using CRUD_MVC.Models;

namespace CRUD_MVC.Database
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}