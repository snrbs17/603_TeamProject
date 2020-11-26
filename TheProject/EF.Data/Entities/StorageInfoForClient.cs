using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Entities
{
    public class StorageInfoForClient
    {
        public int StorageId { get; set; }
        public bool CanUse { get; set; }
        public DateTime Time { get; set; }
    }
}
