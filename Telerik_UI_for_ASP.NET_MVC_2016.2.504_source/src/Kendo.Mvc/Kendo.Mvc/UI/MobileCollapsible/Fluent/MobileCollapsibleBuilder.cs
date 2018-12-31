namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo MobileCollapsible for ASP.NET MVC.
    /// </summary>
    public class MobileCollapsibleBuilder: WidgetBuilderBase<MobileCollapsible, MobileCollapsibleBuilder>
    {
        private readonly MobileCollapsible container;
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileCollapsible"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public MobileCollapsibleBuilder(MobileCollapsible component)
            : base(component)
        {
            container = component;
        }

        //>> Fields
        
        /// <summary>
        /// Turns on or off the animation of the widget.
        /// </summary>
        /// <param name="value">The value that configures the animation.</param>
        public MobileCollapsibleBuilder Animation(bool value)
        {
            container.Animation = value;

            return this;
        }
        
        /// <summary>
        /// If set to false the widget content will be expanded initially. The content of the widget is collapsed by default.
        /// </summary>
        /// <param name="value">The value that configures the collapsed.</param>
        public MobileCollapsibleBuilder Collapsed(bool value)
        {
            container.Collapsed = value;

            return this;
        }
        
        /// <summary>
        /// Sets the icon for the header of the collapsible widget when it is in a expanded state.
        /// </summary>
        /// <param name="value">The value that configures the expandicon.</param>
        public MobileCollapsibleBuilder ExpandIcon(string value)
        {
            container.ExpandIcon = value;

            return this;
        }
        
        /// <summary>
        /// Forses inset appearance - the collapsible panel is padded from the View and receives rounded corners.
        /// </summary>
        /// <param name="value">The value that configures the inset.</param>
        public MobileCollapsibleBuilder Inset(bool value)
        {
            container.Inset = value;

            return this;
        }
        
        //<< Fields

        /// <summary>
        /// Sets the HTML content which the header should display.
        /// </summary>
        /// <param name="value">The action which renders the header.</param>
        /// <code lang="CS">
        ///  &lt;% Html.Kendo().MobileCollapsible()
        ///            .Name("Collapsible")
        ///            .Header(() =>
        ///                     {
        ///                         %&gt;
        ///                             &lt;strong&gt; Collapsible Header &lt;/strong&gt;
        ///                         &lt;%
        ///                     })
        ///            .Render();
        /// %&gt;
        /// </code>
        public MobileCollapsibleBuilder Header(Action value)
        {
            container.Header.Content = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the header should display.
        /// </summary>
        /// <param name="value">The content wrapped in a regular HTML tag or text tag (Razor syntax).</param>
        /// <code lang="CS">
        ///  @(Html.Kendo().MobileCollapsible()
        ///       .Name("Collapsible")        
        ///        .Header(
        ///             @&lt;text&gt;
        ///                     Some text
        ///                     &lt;strong&gt; Collapsible Header &lt;/strong&gt;
        ///             &lt;/text&gt;        
        ///       )
        ///  )
        /// </code>
        public MobileCollapsibleBuilder Header(Func<object, object> value)
        {
            container.Header.InlineTemplate = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the header should display as a string.
        /// </summary>
        /// <param name="value">The action which renders the header.</param>
        /// <code lang="CS">
        ///  &lt;% Html.Kendo().MobileCollapsible()
        ///            .Name("Collapsible")
        ///            .Header("&lt;strong&gt; Collapsible Header &lt;/strong&gt;");        
        ///            .Render();
        /// %&gt;
        /// </code>
        public MobileCollapsibleBuilder Header(string value)
        {

            container.Header.Html = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the content should display.
        /// </summary>
        /// <param name="value">The action which renders the content.</param>
        /// <code lang="CS">
        ///  &lt;% Html.Kendo().MobileCollapsible()
        ///            .Name("Collapsible")
        ///            .Content(() =>
        ///                     {
        ///                         %&gt;
        ///                             &lt;strong&gt; Collapsible Content &lt;/strong&gt;
        ///                         &lt;%
        ///                     })
        ///            .Render();
        /// %&gt;
        /// </code>
        public MobileCollapsibleBuilder Content(Action value)
        {
            container.Content.Content = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the content should display.
        /// </summary>
        /// <param name="value">The content wrapped in a regular HTML tag or text tag (Razor syntax).</param>
        /// <code lang="CS">
        ///  @(Html.Kendo().MobileCollapsible()
        ///       .Name("Collapsible")        
        ///        .Content(
        ///             @&lt;text&gt;
        ///                     Some text
        ///                     &lt;strong&gt; Collapsible Content &lt;/strong&gt;
        ///             &lt;/text&gt;        
        ///       )
        ///  )
        /// </code>
        public MobileCollapsibleBuilder Content(Func<object, object> value)
        {
            container.Content.InlineTemplate = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content which the view content should display as a string.
        /// </summary>
        /// <param name="value">The action which renders the view content.</param>
        /// <code lang="CS">
        ///  &lt;% Html.Kendo().MobileCollapsible()
        ///            .Name("Collapsible")
        ///            .Content("&lt;strong&gt; Collapsible Content &lt;/strong&gt;");        
        ///            .Render();
        /// %&gt;
        /// </code>
        public MobileCollapsibleBuilder Content(string value)
        {

            container.Content.Html = value;

            return this;
        }
        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MobileCollapsible()
        ///             .Name("MobileCollapsible")
        ///             .Events(events => events
        ///                 .Collapse("onCollapse")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public MobileCollapsibleBuilder Events(Action<MobileCollapsibleEventBuilder> configurator)
        {

            configurator(new MobileCollapsibleEventBuilder(Component.Events));

            return this;
        }
        
        /// <summary>
        /// Sets the icon position in the header of the collapsible widget. Possible values are "left", "right", "top".
        /// </summary>
        /// <param name="value">The value that configures the iconposition.</param>
        public MobileCollapsibleBuilder IconPosition(IconPosition value)
        {
            container.IconPosition = value;

            return this;
        }
        
    }
}

