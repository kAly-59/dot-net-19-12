using System.Linq.Expressions;

namespace Exo04.Repository
{
    public interface IRepository<TENtity> where TENtity : class
    {
        //CREATE
        TENtity Add(TENtity entity);

        //READ
        TENtity? GetById(int id);
        TENtity? Get(Expression<Func<TENtity, bool>> predicate);
    }
}
