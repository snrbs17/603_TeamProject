using EF.Data.Entities;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EF.Data.Dao
{
    public class PaymentDao 
    {
        
        public List<PaymentEntity> GetList(List<StorageInfoForClientEntity> list)
        {
            using (var context = new projectEntities())
            {
                var query = from x in list
                            join y in context.StorageSelections on x.StorageId equals y.StorageId
                            join z in context.Fees on y.FeeId equals z.FeeId
                            select new PaymentEntity
                            {
                                StorageId = x.StorageId,
                                StorageTypeId = x.StorageTypeId,
                                EntryDate = DateTime.Now,

                            };

                return query.ToList();
            }
        }
        
        public void InputData(List<PaymentEntity> paymentList)
        {
            using (var context = new projectEntities())
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
    