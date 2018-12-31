namespace Kendo.Mvc.UI.Fluent
{
    using Kendo.Mvc.UI;
    using System;

    /// <summary>
    /// Defines the fluent interface for configuring series highlight.
    /// </summary>
    public class ChartSeriesHighlightBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeriesHighlightBuilder"/> class.
        /// </summary>
        /// <param name="highlight">The series highlight.</param>
        public ChartSeriesHighlightBuilder(ChartSeriesHighlight highlight)
        {
            Highlight = highlight;
        }

        /// <summary>
        /// Gets or sets the highlight
        /// </summary>
        protected ChartSeriesHighlight Highlight
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the highlight visibility
        /// </summary>
        /// <param name="visible">The highlight visibility.</param>       
        public ChartSeriesHighlightBuilder Visible(bool visible)
        {
            Highlight.Visible = visible;
            return this;
        }

        /// <summary>
        /// Sets the highlight toggle handler
        /// </summary>
        /// <param name="handler">The toggle handler name.</param>  
        public ChartSeriesHighlightBuilder Toggle(string handler)
        {
            Highlight.Toggle = new ClientHandlerDescriptor
            {
                HandlerName = handler
            };
            return this;
        }

        /// <summary>
        /// Sets the highlight toggle handler
        /// </summary>
        /// <param name="handler">The toggle handler</param>  
        public ChartSeriesHighlightBuilder Toggle(Func<object, object> handler)
        {
            Highlight.Toggle = new ClientHandlerDescriptor
            {
                TemplateDelegate = handler
            };
            return this;
        }


        /// <summary>
        /// Sets the highlight visual handler
        /// </summary>
        /// <param name="handler">The visual handler name.</param>  
        public ChartSeriesHighlightBuilder Visual(string handler)
        {
            Highlight.Visual = new ClientHandlerDescriptor
            {
                HandlerName = handler
            };
            return this;
        }

        /// <summary>
        /// Sets the highlight visual handler
        /// </summary>
        /// <param name="handler">The visual handler</param>  
        public ChartSeriesHighlightBuilder Visual(Func<object, object> handler)
        {
            Highlight.Visual = new ClientHandlerDescriptor
            {
                TemplateDelegate = handler
            };
            return this;
        }

    }
}