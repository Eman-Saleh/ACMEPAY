using System;
using System.Collections.Generic;

namespace ACMEPAY.DB.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? OrderDetail { get; set; }
        public int? PaymentId { get; set; }

        public virtual Payment? Payment { get; set; }
    }
}
