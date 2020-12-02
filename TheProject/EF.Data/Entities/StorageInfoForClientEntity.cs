using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Entities
{
    public class StorageInfoForClientEntity
    {
        public int StorageId { get; set; }
        public string CanUse { get; set; }
        //public bool CanUse { get; set; }
        public DateTime Time { get; set; }
        public string StorageTypeName { get; set; }
        public bool Activation { get; set; }
    }
}
