namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo ResponsivePanel for ASP.NET MVC.
    /// </summary>
    public class ResponsivePanelBuilder: WidgetBuilderBase<ResponsivePanel, ResponsivePanelBuilder>
    {
        private readonly ResponsivePanel container;
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsivePanel"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ResponsivePanelBuilder(ResponsivePanel component)
            : base(component)
        {
            container = component;
        }

        /// <summary>
        /// Sets the HTML content which the panel will hide.
        /// </summary>
        /// <param name="value">The action which renders the content.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;% Html.Kendo().ResponsivePanel()
        ///            .Name("sidebar")
        ///            .Content(() => 
        ///            { 
        ///               %&gt;
        ///                     &lt;strong&gt;Panel content&lt;/strong&gt;
        ///               &lt;% 
        ///            })
        /// %&gt;
        /// </code>
        /// </example>
        public ResponsivePanelBuilder Content(Action value)
        {
            Component.Template.Content = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the panel will hide
        /// </summary>
        /// <param name="value">The Razor inline template</param>
        /// <example>
        /// <code lang="CS">
        ///  @(Html.Kendo().ResponsivePanel()
        ///            .Name("sidebar")
        ///            .Content(@&lt;strong&gt; Hello World!&lt;/strong&gt;))
        /// </code>        
        /// </example>
        /// <returns></returns>
        public ResponsivePanelBuilder Content(Func<object, object> value)
        {
            Component.Template.InlineTemplate = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the panel will hide as a string.
        /// </summary>
        /// <param name="value">The action which renders the content.</param>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ResponsivePanel()
        ///             .Name("sidebar")
        ///             .Content("&lt;strong&gt; First Item Content&lt;/strong&gt;")
        /// %&gt;
        /// </code>        
        public ResponsivePanelBuilder Content(string value)
        {
            Component.Template.Html = value;

            return this;
        }

        //>> Fields
        
        /// <summary>
        /// If set to false the widget will not close when the page content is touched, after it was opened on a mobile device. You will need to call the close method when the panel needs to close.
        /// </summary>
        /// <param name="value">The value that configures the autoclose.</param>
        public ResponsivePanelBuilder AutoClose(bool value)
        {
            container.AutoClose = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the page width at which the widget will be hidden and its toggle button will become visible.
        /// </summary>
        /// <param name="value">The value that configures the breakpoint.</param>
        public ResponsivePanelBuilder Breakpoint(double value)
        {
            container.Breakpoint = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the direction from which the hidden element will open up, once the toggle button has been activated. Valid values are "left", "right", and "top".
        /// </summary>
        /// <param name="value">The value that configures the orientation.</param>
        public ResponsivePanelBuilder Orientation(string value)
        {
            container.Orientation = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the selector for the toggle button that will show and hide the responsive panel.
        /// </summary>
        /// <param name="value">The value that configures the togglebutton.</param>
        public ResponsivePanelBuilder ToggleButton(string value)
        {
            container.ToggleButton = value;

            return this;
        }
        
        //<< Fields


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ResponsivePanel()
        ///             .Name("ResponsivePanel")
        ///             .Events(events => events
        ///                 .Close("onClose")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public ResponsivePanelBuilder Events(Action<ResponsivePanelEventBuilder> configurator)
        {

            configurator(new ResponsivePanelEventBuilder(Component.Events));

            return this;
        }
        
    }
}

