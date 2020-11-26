using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Dao
{
    public class StorageSelectionDao : SingleKeyDao<StorageSelection, int>
    {
        protected override Expression<Func<StorageSelection, int>> KeySelector => x => x.StorageSelectionId;

        protected override Expression<Func<StorageSelection, bool>> IsKey(int key)
        {
            return x => x.StorageSelectionId == key;
        }
    }
}
