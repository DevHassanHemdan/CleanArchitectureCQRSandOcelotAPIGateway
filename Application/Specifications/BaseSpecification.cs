using System.Linq.Expressions;
namespace Application.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public BaseSpecification(Expression<Func<T, bool>> _Criteria)
        {
            Criteria = _Criteria;
        }

        protected void AddInclude(Expression<Func<T,object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
