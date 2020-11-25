using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public abstract class TripleKeyDao<T, K1, K2, K3> : BaseDao<T> where T : class
    {
        public T GetByPK(K1 key1, K2 key2, K3 key3)
        {
            using (var context = DbContextCreator.Context())
            {
                var query = context
                    .Set<T>()
                    .Where(IsKey(key1, key2, key3))
                    .Select(x => x);

                return query.FirstOrDefault();
            }
        }

        protected abstract Expression<Func<T, bool>> IsKey(K1 key1, K2 key2, K3 key3);

        public void DeleteByPK(K1 key1, K2 key2, K3 key3)
        {
            T entity = GetByPK(key1, key2, key3);

            if (entity != null)
                Delete(entity);
        }
    }
}