using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class FeeDao : SingleKeyDao<Fee, int>
    {
        protected override Expression<Func<Fee, int>> KeySelector => x => x.FeeId;

        protected override Expression<Func<Fee, bool>> IsKey(int key)
        {
            return x => x.FeeId == key;
        }
    }
}
