using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class Dao
    {
        public static StorageInfoForClientDao StorageInfoForClient { get; } = new StorageInfoForClientDao();
        public static StorageDao Storage { get; } = new StorageDao();
        public static ImportDao Import { get; } = new ImportDao();
        public static PaymentDao Payment { get; } = new PaymentDao();
    }
}
