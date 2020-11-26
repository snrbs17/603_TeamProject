using System;

namespace EF.Data.Entities
{
    public class PaymentEntity
    {
        public int StorageId { get; set; }
        public int StorageTypeId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDateExpected { get; set; }
        public int TimePassId { get; set; }
        public int Cost { get; set; }
    }
}
