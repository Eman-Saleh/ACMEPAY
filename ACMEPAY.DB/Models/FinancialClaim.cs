using System;
using System.Collections.Generic;

namespace ACMEPAY.DB.Models
{
    public partial class FinancialClaim
    {

        public int ID { get; set; }
        public int? SectorId { get; set; }
        public string? ClaimNumber { get; set; }
        public decimal ClaimAmount { get; set; }
        public decimal? TransferAmount { get; set; }
        public DateTime? TransferDate { get; set; }
        public int? ClaimAmountCurrency { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string? VendorName { get; set; }
        public string? Subject { get; set; }
        public string? PaymentType { get; set; }
        public string? AccountNumber { get; set; }
        public string? TransferBank { get; set; }

        public string? PurchaseType { get; set; }
        public string? CheckNumber { get; set; }
        public string? Notes { get; set; }
        public string? LastSectorComment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? SentBy { get; set; }
        public DateTime? SentDate { get; set; }
        public int? LastAdministrativeStatus { get; set; }
        public DateTime? LastAdministrativeStatusDate { get; set; }
        public string? LastAdministrativeComments { get; set; }
        public string? LastAdministrativeNotes { get; set; }
        public int? LastAdministrativeSentBy { get; set; }
        public int? LastFinancialSentBy { get; set; }
        public int? LastOperationTransSentBy { get; set; }

        public int? LastFinancialStatus { get; set; }
        public DateTime? LastFinancialStatusDate { get; set; }
        public string? LastFinancialComments { get; set; }
        public string? LastFinancialNotes { get; set; }

        public int? LastOperationTransStatus { get; set; }
        public DateTime? LastOperationTransStatusDate { get; set; }
        public string? LastOperationTransComments { get; set; }
        public string? LastOperationTransNotes { get; set; }

        public int? LogId { get; set; }
        public int? QueueId { get; set; }
        public bool? AdministrativeDeliverCheck { get; set; }
    }
}
