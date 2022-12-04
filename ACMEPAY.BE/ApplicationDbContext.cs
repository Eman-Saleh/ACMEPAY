using ACMEPAY.DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;

namespace ACMEPAY.BE
{
    public class ApplicationDbContext : DbContext
    {
     
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<FinancialClaim> FinancialClaims { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;


    }
}
