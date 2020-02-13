using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}