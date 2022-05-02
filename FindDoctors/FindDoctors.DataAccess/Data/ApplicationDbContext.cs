using FindDoctors.Models;
using Microsoft.EntityFrameworkCore;

namespace FindDoctors.DataAccess
{
	public class ApplicationDbContext : DbContext
	{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

	}
}
