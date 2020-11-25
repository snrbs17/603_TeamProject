﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public abstract class SingleKeyDao<T, K> : BaseDao<T> where T : class
    {
        public T GetByPK(K key)
        {
            using (var context = DbContextCreator.Context())
            {
                return context.Set<T>()
                    .Where(IsKey(key))
                    .FirstOrDefault();
            }
        }

        protected abstract Expression<Func<T, bool>> IsKey(K key);

        public void DeleteByPK(K key)
        {
            T entity = GetByPK(key);

            if (entity != null)
                Delete(entity);
        }

        public K GetMaxKey()
        {
            using (var context = DbContextCreator.Context())
            {
                var query = context.Set<T>()
                    .OrderByDescending(KeySelector)
                    .Select(KeySelector);

                return query.FirstOrDefault();
            }
        }

        protected abstract Expression<Func<T, K>> KeySelector { get; }
    }
}
