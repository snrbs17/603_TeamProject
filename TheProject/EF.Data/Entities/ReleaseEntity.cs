using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Entities
{
    public class ReleaseEntity
    {
        public int StorageId { get; set; }
        public int FacilityId { get; set; }
        public int StorageTypeId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
