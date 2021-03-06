using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Polyrific.Project.Core
{
    /// <summary>
    /// Base interface of the specification
    /// </summary>
    /// <typeparam name="TEntity">The entity class used in the specification</typeparam>
    public interface ISpecification<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Search filter criteria
        /// </summary>
        Expression<Func<TEntity, bool>> Criteria { get; }

        /// <summary>
        /// Order by ascending criteria
        /// </summary>
        Expression<Func<TEntity, object>> OrderBy { get; }

        /// <summary>
        /// List of "order by - ascending" criteria
        /// </summary>
        List<Expression<Func<TEntity, object>>> OrderByList { get; }

        /// <summary>
        /// Order by descending criteria
        /// </summary>
        Expression<Func<TEntity, object>> OrderByDescending { get; }

        /// <summary>
        /// List of "order by - descending" criteria
        /// </summary>
        List<Expression<Func<TEntity, object>>> OrderByDescendingList { get; }

        /// <summary>
        /// Related entities to be included in the query
        /// </summary>
        List<Expression<Func<TEntity, object>>> Includes { get; }

        /// <summary>
        /// Related entities to be included in the query
        /// </summary>
        List<string> IncludeStrings { get; }

        /// <summary>
        /// The number of items to skip
        /// </summary>
        int? Skip { get; }

        /// <summary>
        /// The maximum number of items to return
        /// </summary>
        int? Take { get; }

        /// <summary>
        /// Query selector
        /// </summary>
        Expression<Func<TEntity, TEntity>> Selector { get; }
    }
}
