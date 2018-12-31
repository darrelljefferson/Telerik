namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo MobileCollapsible for ASP.NET MVC events.
    /// </summary>
    public class MobileCollapsibleEventBuilder: EventBuilder
    {
        public MobileCollapsibleEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        //>> Handlers
        
        /// <summary>
        /// Fires when the user collapses the content.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapse event.</param>
        public MobileCollapsibleEventBuilder Collapse(string handler)
        {
            Handler("collapse", handler);

            return this;
        }
        
        /// <summary>
        /// Fires when the user expands the content.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expand event.</param>
        public MobileCollapsibleEventBuilder Expand(string handler)
        {
            Handler("expand", handler);

            return this;
        }
        
        //<< Handlers
    }
}

