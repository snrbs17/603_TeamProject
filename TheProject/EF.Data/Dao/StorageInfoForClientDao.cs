using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class StorageInfoForClientDao
    {
        public List<StorageInfoForClientEntity> GetList()
        {
            using (var context = new projectEntities())
            {
                var query = from x in context.Storages
                            join y in context.StorageSelections on x.StorageId equals y.StorageId
                            join z in context.StorageTypes on x.StorageTypeId equals z.StorageTypeId
                            select new StorageInfoForClientEntity
                            {
                                StorageId = x.StorageId,
                                StorageTypeName = z.StorageTypeName,
                                CanUse = x.MemberId == null ? "사용가능" : "사용불가",
                                Time = x.MemberId == null ? (DateTime?)null : y.ExitDateExpected,
                                Activation = x.Activation
                            };

                return query.ToList();
            }
        }

    }
}
