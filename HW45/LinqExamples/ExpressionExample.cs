using System;
using System.Linq.Expressions;
public static class ExpressionExample
{
    public static Expression<Func<Product, int>> ProductPriceSelector => CreateProductPriceSelector();
    public static Expression<Func<Product, int>> CreateProductPriceSelector()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Product));
        MemberExpression property = Expression.Property(parameter, "Price");

        var selector = Expression.Lambda<Func<Product, int>>(property, parameter);

        return selector;
    }

    public static Expression<Func<Product, bool>> CreateProductFilter(Rule[] filter)
    {
        var parameter = Expression.Parameter(typeof(Product));

        BinaryExpression expression = null;

        foreach (var rule in filter) 
        {
            var property = Expression.Property(parameter, rule.PropertyName);
            var value = Expression.Constant(rule.Value);

            var newExpression = Expression.MakeBinary(rule.ExpressionType, property, value);

            expression = expression is null
                ? newExpression
                : Expression.MakeBinary((ExpressionType)rule.AppendType, expression, newExpression);
        }

        var lambda = Expression.Lambda<Func<Product, bool>>(expression, parameter);
        return lambda;
    }

}
