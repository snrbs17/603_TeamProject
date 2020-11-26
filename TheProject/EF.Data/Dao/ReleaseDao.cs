using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class ReleaseDao
    {
        public List<ReleaseEntity> GetList()
        {
            using(var context = new projectEntities())
            {
                var query = from x in context.Storages
                            join y in context.StorageSelections on x.StorageId equals y.StorageId
                            join z in context.Fees on y.FeeId equals z.FeeId
                            select new ReleaseEntity
                            {
                                StorageId = x.StorageId,
                                FacilityId = x.FacilityId,
                                StorageTypeId = x.StorageTypeId,
                                EntryDate = y.EntryDate
                            };

                return query.ToList();
            }
        }
    }
}
