using DataLayer.Entities;

namespace DataLayer.Repositories.Interfaces
{
    public interface IRepository<TEntity, TKey>
        where TEntity : Entity
        where TKey : IEquatable<TKey>
    {
        void Add(TEntity entity);
        void Delete(TKey id);
        void Update(TEntity entity);
        TEntity Get(TKey id);
        TEntity GetAll();
    }

    public interface IRepository<TEntity> : IRepository<TEntity, string>
        where TEntity : Entity
    { }
}
