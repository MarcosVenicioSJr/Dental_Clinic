using Dental_Clinic.Models;
using Microsoft.EntityFrameworkCore;

namespace Dental_Clinic.Context
{
    public class DentalClinicContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Patient> Patient { get; set; }

        public DentalClinicContext(DbContextOptions<DentalClinicContext> options)
    : base(options)
        {
        }
    }
}
