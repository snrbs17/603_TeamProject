using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public abstract class DualKeyDao<T, K1, K2> : BaseDao<T> where T : class
    {
        public T GetByPK(K1 key1, K2 key2)
        {
            using (var context = DbContextCreator.Context())
            {
                var query = context
                    .Set<T>()
                    .Where(IsKey(key1, key2))
                    .Select(x => x);

                return query.FirstOrDefault();
            }
        }

        protected abstract Expression<Func<T, bool>> IsKey(K1 key1, K2 key2);

        public void DeleteByPK(K1 key1, K2 key2)
        {
            T entity = GetByPK(key1, key2);

            if (entity != null)
                Delete(entity);
        }
    }
}
