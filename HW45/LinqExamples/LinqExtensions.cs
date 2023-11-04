using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace LinqExamples
{
    public static class LinqExtensions
    {
        public static IQueryable<TSource> OrderByFieldOrProperty<TSource>
            (this IQueryable<TSource> queryable, string propertyOrFieldName, bool ascending = true)
        {
            var type = typeof (TSource);
            var orderByMethodName = ascending ? nameof(Queryable.OrderBy) : nameof(Queryable.OrderByDescending);

            var parameter = Expression.Parameter(type);
            var propertyOrField = Expression.PropertyOrField(parameter, propertyOrFieldName);
            var selector = Expression.Lambda(propertyOrField, parameter);

            var orderByExpression = Expression.Call(
                typeof(Queryable),
                orderByMethodName,
                new[] { type, propertyOrField.Type },
                queryable.Expression,
                selector);

            return queryable.Provider.CreateQuery<TSource>(orderByExpression);
        }
            

    }
}
