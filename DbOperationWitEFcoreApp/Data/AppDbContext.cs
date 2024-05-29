using Microsoft.EntityFrameworkCore;
namespace DbOperationWitEFcoreApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
    }
}
