using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Form5
{
    public class BoxDao : SingleKeyDao<box, int>
    {
        internal BoxDao() { }

        protected override Expression<Func<box, bool>> IsKey(int key)
        {
            return x => x.boxID == key;
        }

        protected override Expression<Func<box, int>> KeySelector =>
            x => x.boxID;
    }
}
