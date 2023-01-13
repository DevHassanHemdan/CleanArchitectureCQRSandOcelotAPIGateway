using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Specifications
{
    public class SpecificationEvaluator<T> where T : BaseClass
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {
            var query = inputQuery;
            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }
            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}
