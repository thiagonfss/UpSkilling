using System.Data;
using System.Linq.Expressions;

namespace Estacionamento.Repository.Interfaces;

public interface ISqLiteBaseRepository<T>
{
    IQueryable<T> Get();
    void Post(T entidade);
    void Delete(T entidade);
    void Update(T entidade);

}