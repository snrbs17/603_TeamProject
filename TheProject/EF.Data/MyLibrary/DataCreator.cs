using EF.Data;
using EF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static EF.Data.Dao.ImportDao;

namespace MyLibrary
{
    public class DataCreator
    {
        public static Func<RecieptSelectionStorage, bool> TimeScope { get; set; }
        public static Func<RecieptSelectionStorage, int> TimeUnit { get; set; }

        public static Func<RecieptSelectionStorage, bool> TypeSelect { get; set; }
    }
}
