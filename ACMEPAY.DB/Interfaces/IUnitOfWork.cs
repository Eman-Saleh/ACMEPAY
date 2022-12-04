using ACMEPAY.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEPAY.DB.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Payment> Payments { get; }
     

        int Complete();
    }
}
