namespace Gestion_Itv.Repository;

public interface ICrudRepo<in TKey, TEntity> where TEntity : class
{
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(TKey id);
        TEntity? Create(TEntity entity);
        TEntity? Delete(TKey id);
}