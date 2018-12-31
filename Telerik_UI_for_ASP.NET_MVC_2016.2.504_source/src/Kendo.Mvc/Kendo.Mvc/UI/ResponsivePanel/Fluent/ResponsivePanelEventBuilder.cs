namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo ResponsivePanel for ASP.NET MVC events.
    /// </summary>
    public class ResponsivePanelEventBuilder: EventBuilder
    {
        public ResponsivePanelEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        //>> Handlers
        
        /// <summary>
        /// Triggered before the responsive panel is closed. Cancellable.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public ResponsivePanelEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }
        
        /// <summary>
        /// Triggered before the responsive panel is opened. Cancellable.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public ResponsivePanelEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }
        
        //<< Handlers
    }
}

