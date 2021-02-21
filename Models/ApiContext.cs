using Microsoft.EntityFrameworkCore;

namespace SimplyFieldServicing.Models
{
    public class ApiContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SqlExpress;Database=SimplyFieldServicing;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}