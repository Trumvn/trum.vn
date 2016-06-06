using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Trumvn.Base
{
    public interface IRepository<TEntity, in TKey> where TEntity : class 
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> List { get; }
        void Add(TEntity entity);
        void Save(TEntity entity);
        void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties);
        void Delete(TEntity entity);
        void Delete(TKey id);
    }
}
