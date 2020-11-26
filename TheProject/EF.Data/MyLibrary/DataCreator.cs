using EF.Data;
using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class DataCreator
    {
        public static Func<Reciept, bool> TimeScope { get; set; }
        public static Func<Reciept, int> TimeUnit { get; set; }
            //= (x, month) => x.PaymentDate.Month == month;
    }
}
