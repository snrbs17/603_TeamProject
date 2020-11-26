﻿using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class PaymentDao
    {
        public List<PaymentEntity> GetList()
        {
            using(var context = new projectEntities())
            {
                var query = from x in context.Storages
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
