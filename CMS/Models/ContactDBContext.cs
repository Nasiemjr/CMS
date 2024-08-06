using Microsoft.EntityFrameworkCore;

namespace CMS.Models
{
    public class ContactDBContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CMSDB");
        }
    }
}
