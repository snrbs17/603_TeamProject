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
        public static EarningDao Earning { get; } = new EarningDao();
        public static PaymentDao Payment { get; } = new PaymentDao();
        public static ReleaseDao Release { get; } = new ReleaseDao();
        public static SearchDao Search { get; } = new SearchDao();
    }
}
