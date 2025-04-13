using Microsoft.EntityFrameworkCore;
using CivilAviationSystem.Models;

namespace CivilAviationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // استخدام قاعدة بيانات SQLite
            options.UseSqlite("Data Source=aviationSystem.db");
        }
    }
}
