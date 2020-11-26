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

        public Func<Reciept, int> DaylyUnit;
        public List<ImportEntity> ImpoprtPerUnitTime(Func<Reciept,bool> function)
        {
            using (var context = new projectEntities())
            {
                var query = context.Reciepts
                    .Where(function)
                    .GroupBy(function2, x => x.TotalCost,
                    (key, entities) => new ImportEntity { TimeUnit = key, Cost = entities.Sum() });
                                        
                return query.ToList();
            }
        }


        public List<ImportEntity> YearlyImpoprt(int year)
        {
            using (var context = new projectEntities())
            {
                var query = from x in context.Reciepts
                            where x.PaymentDate.Year == year
                            group x.TotalCost by x.PaymentDate.Month into g
                            select new ImportEntity
                            {
                                TimeUnit = g.Key,
                                Cost = g.Sum()
                            };

                return query.ToList();
            }
        }


    }
}
