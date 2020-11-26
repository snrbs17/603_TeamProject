using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class ImportDao
    {
        public List<Import> MonthlyImpoprt(int month)
        {
            using (var context = new projectEntities())
            {
                var query = from x in context.Reciepts
                            where x.PaymentDate.Month == month
                            group x.TotalCost by x.PaymentDate.Day into g
                            select new Import
                            {
                                Day = g.Key,
                                Cost = g.Sum()
                            };

                return query.ToList();
            }
        }
    }
}
