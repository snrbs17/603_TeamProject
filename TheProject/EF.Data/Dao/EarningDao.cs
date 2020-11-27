using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class EarningDao
    {
        public Func<RecieptSelectionStorage, bool> Monthly(int month) => x => x.reciept.PaymentDate.Month == month;
        public Func<RecieptSelectionStorage, bool> Yearly(int year) => x => x.reciept.PaymentDate.Year == year;

        public Func<RecieptSelectionStorage, int> DaylyUnit() => x => x.reciept.PaymentDate.Day;
        public Func<RecieptSelectionStorage, int> MonthlyUnit() => x => x.reciept.PaymentDate.Month;

        public Func<RecieptSelectionStorage, bool> AnyType() => x => true;
        public Func<RecieptSelectionStorage, bool> Fridge() => x => x.storage.StorageTypeId == 1;
        public Func<RecieptSelectionStorage, bool> Normal() => x => x.storage.StorageTypeId == 2;
        

        
        public class RecieptSelectionStorage       
        {
            public Reciept reciept;
            public StorageSelection storageSelection;
            public Storage storage;
        }

        public List<EarningEntity> EarningPerUnitTime(Func<RecieptSelectionStorage,bool> SelectTimeScope, Func<RecieptSelectionStorage,int> SelectTimeUnit, Func<RecieptSelectionStorage, bool> TypeSelect)
        {
            using (var context = new projectEntities())
            {
                var query = context.StorageSelections
                    .Join(context.Reciepts, x => x.ReceiptId, y => y.ReceiptId, (x, y) => new { x, y })
                    .Join(context.Storages, xy => xy.x.StorageId, z => z.StorageId, (xy, z) => new RecieptSelectionStorage { reciept = xy.y, storageSelection = xy.x, storage = z })
                    .OrderBy(SelectTimeUnit)
                    .Where(SelectTimeScope)
                    .Where(TypeSelect)
                    .OrderBy(SelectTimeUnit)
                    .GroupBy(SelectTimeUnit, x => x.storageSelection.FeeId, (key, entities) => new EarningEntity { TimeUnit = key, Cost = entities.Sum() *1000  });
                                        
                return query.ToList();
            }
        }
    }
}
