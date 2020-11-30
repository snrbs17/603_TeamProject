using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Entities
{
    public class SearchEntity
    {
        public string Region { get; set; }
        public int StorageId { get; set; }
        public int StorageTypeId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDateExpected { get; set; }
        public TimeSpan RemainingTime { get; set; }
    }
}
