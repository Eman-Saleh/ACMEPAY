using ACMEPAY.DB.Interfaces;
using ACMEPAY.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEPAY.BE.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<AuditLog> AuditLogs { get; private set; }

        public IBaseRepository<FinancialClaim> FinancialClaims { get; private set; }

        public IBaseRepository<Payment> Payments { get; private set; }

        public IBaseRepository<Order> Orders { get; private set; }

        public UnitOfWork (ApplicationDbContext context )
        { 
            _context = context;
            AuditLogs =new BaseRepository<AuditLog>(_context);
            FinancialClaims = new BaseRepository<FinancialClaim>(_context);
            Orders = new BaseRepository<Order>(_context);
            Payments = new BaseRepository<Payment>(_context);

        }
       

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
