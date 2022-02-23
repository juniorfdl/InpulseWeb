using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Inpulse.WebApi.Base
{
    public static class ExpressionExtension
    {
        public static Expression<Func<T, bool>> AndAlso<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
            => Expression.Lambda<Func<T, bool>>( Expression.AndAlso(left.Body, new SubstExpressionVisitor {Subst = {[right.Parameters[0]] = left.Parameters[0]}}.Visit(right.Body)!), left.Parameters[0]);
        

        public static Expression<Func<T, bool>> OrAlso<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
            =>  Expression.Lambda<Func<T, bool>>(Expression.OrElse(left.Body,  new SubstExpressionVisitor {Subst = {[right.Parameters[0]] = left.Parameters[0]}}.Visit(right.Body)!), left.Parameters[0]);
        
    }

    internal class SubstExpressionVisitor : ExpressionVisitor
    {
        public readonly Dictionary<Expression, Expression> Subst = new Dictionary<Expression, Expression>();

        protected override Expression VisitParameter(ParameterExpression node)
            => Subst.TryGetValue(node, out var newValue) ? newValue : node;
    }
}