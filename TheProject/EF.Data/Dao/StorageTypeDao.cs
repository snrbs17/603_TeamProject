using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    class StorageTypeDao : SingleKeyDao<StorageType, int>
    {
        protected override Expression<Func<StorageType, int>> KeySelector => x => x.StorageTypeId;

        protected override Expression<Func<StorageType, bool>> IsKey(int key)
        {
            return x => x.StorageTypeId == key;
        }
    }
}
