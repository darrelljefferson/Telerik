namespace Kendo.Mvc.UI.Fluent
{
    using System;
    public class ChartLegendItemBuilder
    {
        private readonly ChartLegendItem legendItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartLegendItemBuilder" /> class.
        /// </summary>
        /// <param name="legendItem">The chart legend item.</param>
        public ChartLegendItemBuilder(ChartLegendItem legendItem)
        {
            this.legendItem = legendItem;
        }

        /// <summary>
        /// Sets the legend item cursor style
        /// </summary>
        /// <param name="cursor">The cursor style.</param>  
        public ChartLegendItemBuilder Cursor(string cursor)
        {
            legendItem.Cursor = cursor;

            return this;
        }

        /// <summary>
        /// Sets the legend item visual handler
        /// </summary>
        /// <param name="handler">The handler name.</param>  
        public ChartLegendItemBuilder Visual(string handler)
        {
            legendItem.Visual = new ClientHandlerDescriptor
            {
                HandlerName = handler
            };
            return this;
        }

        /// <summary>
        /// Sets the note visual handler
        /// </summary>
        /// <param name="handler">The handler</param>  
        public ChartLegendItemBuilder Visual(Func<object, object> handler)
        {
            legendItem.Visual = new ClientHandlerDescriptor
            {
                TemplateDelegate = handler
            };
            return this;
        }
    }
}
