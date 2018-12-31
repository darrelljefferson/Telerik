namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Web.Mvc;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.Resources;

    public class GanttBoundColumn<TModel, ТValue> : GanttColumnBase<TModel>, IGanttColumn
        where TModel : class, IGanttTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GanttBoundColumn{TModel, TValue}"/> class.
        /// </summary>
        /// <param name="Gantt"></param>
        /// <param name="expression"></param>
        public GanttBoundColumn(Expression<Func<TModel, ТValue>> expression)
            : base()
        {
            if (typeof(TModel).IsPlainType() && !expression.IsBindable())
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            Member = expression.MemberWithoutInstance();

            if (typeof(TModel).IsPlainType())
            {
                ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<TModel>());
                Title = metadata.DisplayName;
                Format = metadata.DisplayFormatString;
            }

            if (string.IsNullOrEmpty(Title))
            {
                Title = Member.AsTitle();
            }

            if (typeof(IGanttTask).GetProperty(Member) != null)
            {
                Member = Member.ToCamelCase();
            }
        }
    }
}