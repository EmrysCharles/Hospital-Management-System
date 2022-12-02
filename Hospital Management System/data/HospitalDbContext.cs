using Hospital_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }
        //public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        //{
        //}
        public DbSet<Patients> Patients { get; set; }

    }
}

