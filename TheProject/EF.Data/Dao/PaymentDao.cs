﻿using EF.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EF.Data.Dao
{
    public class PaymentDao
    {
        public List<PaymentEntity> GetList(List<StorageInfoForClientEntity> list)
        {
            using(var context = new projectEntities())
            {
                var query = from x in list
                            join y in context.StorageSelections on x.StorageId equals y.StorageId
                            join z in context.Fees on y.FeeId equals z.FeeId
                            select new PaymentEntity
                            {
                                StorageId = x.StorageId,
                                StorageTypeId = x.StorageTypeId,
                                EntryDate = y.EntryDate,
                                ExitDateExpected = y.ExitDateExpected,
                                TimePassId = z.TimePassId,
                                Cost = z.Cost
                            };

                return query.ToList();
            }
        }
    }
}
