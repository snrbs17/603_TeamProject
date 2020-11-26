using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Entities
{
    public class StorageEntity
    {
        public int StorageId { get; set; }
        public int FacilityId { get; set; }
        public int StorageTypeId { get; set; }
        public bool Activation { get; set; }
        public int MemberId { get; set; }
    }
}
