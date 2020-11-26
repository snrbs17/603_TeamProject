using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class StorageDao : SingleKeyDao<Storage, int>
    {
        protected override Expression<Func<Storage, int>> KeySelector => x => x.StorageId;
        protected override Expression<Func<Storage, bool>> IsKey(int key)
        {
            return x => x.StorageId == key;
        }

    }
}
