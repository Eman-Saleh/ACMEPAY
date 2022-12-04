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

        public IBaseRepository<Payment> Payments { get; private set; }


        public UnitOfWork (ApplicationDbContext context )
        { 
            _context = context;
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
