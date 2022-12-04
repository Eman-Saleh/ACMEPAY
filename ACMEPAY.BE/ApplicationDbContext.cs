using ACMEPAY.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ACMEPAY.BE
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Payment> Payments { get; set; } = null!;


    }
}
