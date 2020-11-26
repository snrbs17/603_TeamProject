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
        public List<StorageInfoForClient> GetList()
        {
            using (var context = new projectEntities())
            {
                var query = from x in context.Storages
                            join y in context.StorageSelections on x.StorageId equals y.StorageId
                            select new StorageInfoForClient
                            {
                                StorageId = x.StorageId,
                                StorageTypeId = x.StorageTypeId,
                                CanUse = y.ExitDate != null,
                                Time = y.ExitDateExpected
                            };

                return query.ToList();
            }
        }

    }
}
