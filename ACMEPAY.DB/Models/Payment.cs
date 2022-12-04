using System;
using System.Collections.Generic;

namespace ACMEPAY.DB.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public string? Currency { get; set; }
        public string? Cardholder { get; set; }
        public string? HolderName { get; set; }
        public string? ExpirationMonth { get; set; }
        public string? ExpirationYear { get; set; }
        public string? Cvv { get; set; }
        public string? OrderReference { get; set; }
    }
}
