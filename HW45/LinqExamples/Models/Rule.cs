
using System.Linq.Expressions;
public class Rule
{
    public string PropertyName { get; set; }
    public object Value { get; set; }
    public ExpressionType ExpressionType { get; set; }
    public AppendType AppendType { get; set; } = AppendType.AndAlso;
}
public enum AppendType
{
    AndAlso=3,
    OrElse=37
}
