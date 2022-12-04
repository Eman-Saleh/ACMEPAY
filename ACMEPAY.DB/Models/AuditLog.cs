using System;
using System.Collections.Generic;

namespace ACMEPAY.DB.Models
{
    public partial class AuditLog
    {
        public long Id { get; set; }
        public int VersionNo { get; set; }
        public int UserId { get; set; }
        public int ActionType { get; set; }
        public DateTime ActionDate { get; set; }
        public string TableName { get; set; } = null!;
        public long EntityId { get; set; }
        public string? OldEntity { get; set; }
        public string? NewEntity { get; set; }
        public string? IpAddress { get; set; }
        public string? HostName { get; set; }
    }
}
