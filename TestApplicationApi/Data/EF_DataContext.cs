


using Microsoft.EntityFrameworkCore;

namespace TestApplicationApi.Data
{
    public class EF_DataContext :DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }

        public DbSet<Contact> Contacts {get; set;}
        public DbSet<Acountcs> Acountcss { get; set; }
        public DbSet<Incident> Incidents { get; set; }

    }
}
