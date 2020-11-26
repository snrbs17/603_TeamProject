using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class ImportDao
    {
        public Func<Reciept, bool> Monthly(int month)
        {
            return x => x.PaymentDate.Month == month;
        }

        public Func<Reciept, bool> Yearly(int year)
        {
            return x => x.PaymentDate.Year == year;
        }


        public Func<Reciept, int> DaylyUnit()
        {
            return x => x.PaymentDate.Day;
        }

        public Func<Reciept, int> MonthlyUnit()
        {
            return x => x.PaymentDate.Month;
        }
        

        public List<ImportEntity> ImpoprtPerUnitTime(Func<Reciept,bool> SelectScope, Func<Reciept,int> SelectUnit)
        {
            using (var context = new projectEntities())
            {
                var query = context.Reciepts
                    .Where(SelectScope)
                    .OrderBy(SelectUnit)
                    .GroupBy(SelectUnit, x => x.TotalCost,
                    (key, entities) => new ImportEntity { TimeUnit = key, Cost = entities.Sum() });
                                        
                return query.ToList();
            }
        }
    }
}
