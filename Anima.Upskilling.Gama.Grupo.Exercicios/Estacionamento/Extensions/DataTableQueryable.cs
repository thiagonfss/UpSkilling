using System.Collections;
using System.Data;
using System.Linq.Expressions;

namespace Estacionamento.Extensions;

public class DataTableQueryable<T> : IQueryable<T>
{
    private readonly QueryableDataTable<T> _queryable;

    public DataTableQueryable(DataTable dataTable)
    {
        _queryable = new QueryableDataTable<T>(dataTable);
        Provider = _queryable;
        Expression = Expression.Constant(_queryable);
    }

    public IEnumerator<T> GetEnumerator() => _queryable.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public Type ElementType => typeof(T);

    public Expression Expression { get; }

    public IQueryProvider Provider { get; }
}

public class QueryableDataTable<T> : IQueryProvider, IQueryable<T>
{
    private readonly DataTable _dataTable;

    public QueryableDataTable(DataTable dataTable)
    {
        _dataTable = dataTable;
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new QueryableDataTable<TElement>(_dataTable) { Expression = expression };
    }

    public IQueryable CreateQuery(Expression expression)
    {
        var elementType = expression.Type.GetGenericArguments().First();
        var queryableType = typeof(QueryableDataTable<>).MakeGenericType(elementType);
        var queryable = Activator.CreateInstance(queryableType, _dataTable);

        return (IQueryable)queryable;
    }

    public TResult Execute<TResult>(Expression expression)
    {
        var query = (IEnumerable<TResult>)Execute(expression);
        return query.FirstOrDefault();
    }

    public object Execute(Expression expression)
    {
        var result = _dataTable.AsEnumerable().AsQueryable().Provider.Execute(expression);
        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _dataTable.AsEnumerable().Select(CreateElement).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Type ElementType => typeof(T);

    public Expression Expression { get; set; }

    public IQueryProvider Provider => this;

    private static T CreateElement(DataRow row)
    {
        var element = Activator.CreateInstance<T>();
        var properties = typeof(T).GetProperties();
        foreach (var property in properties)
        {
            if (row.Table.Columns.Contains(property.Name) && row[property.Name] != DBNull.Value)
            {
                property.SetValue(element, row[property.Name], null);
            }
        }

        return element;
    }
}
