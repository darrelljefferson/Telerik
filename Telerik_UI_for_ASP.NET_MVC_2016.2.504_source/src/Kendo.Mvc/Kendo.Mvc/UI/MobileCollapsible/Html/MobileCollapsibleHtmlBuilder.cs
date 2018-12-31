namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;

    public class MobileCollapsibleHtmlBuilder
    {
        private readonly MobileCollapsible component;

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileCollapsibleHtmlBuilder" /> class.
        /// </summary>
        /// <param name="component">The MobileCollapsible component.</param>
        public MobileCollapsibleHtmlBuilder(MobileCollapsible component)
        {
            this.component = component;
        }

        /// <summary>
        /// Builds the MobileCollapsible markup.
        /// </summary>
        /// <returns></returns>
        public IHtmlNode Build()
        {
            var html = CreateElement();
            html.Attribute("data-role", "collapsible")
                .Attribute("id", component.Id);

            CreateHeaderElement(html);
            CreateContentElement(html);

            AddEventAttributes(html, component.Events);

            html.Attribute("data-animation", component.Animation ? "true" : "false");
            html.Attribute("data-collapsed", component.Collapsed ? "true" : "false");

            if (component.CollapseIcon.HasValue())
            {
                html.Attribute("data-collapse-icon", component.ExpandIcon);
            }

            if (component.ExpandIcon.HasValue())
            {
                html.Attribute("data-expand-icon", component.ExpandIcon);
            }

            if (component.IconPosition.HasValue)
            {
                html.Attribute("data-icon-position", component.IconPosition.Value.ToString().ToLower());
            }

            html.Attribute("data-inset", component.Inset ? "true" : "false");

            return html;
        }

        protected virtual IHtmlNode CreateElement()
        {
            return new HtmlElement("div");
        }

        
        protected virtual void AddEventAttributes(IHtmlNode html, IDictionary<string, object> events)
        {
            foreach (var keyValuePair in events)
            {
                var value = keyValuePair.Value as ClientHandlerDescriptor;
                var key = "data-" + keyValuePair.Key;

                if (value.HandlerName.HasValue())
                {
                    html.Attribute(key, value.HandlerName);
                }

            }
        }

        protected virtual void CreateHeaderElement(IHtmlNode html)
        {
            if (component.Header.HasValue())
            {
                var dom = new HtmlElement("h3");

                component.Header.Apply(dom);

                html.Children.Add(dom);
            }
        }

        protected virtual void CreateContentElement(IHtmlNode html)
        {
            if (component.Content.HasValue())
            {
                var dom = new HtmlElement("div");

                component.Content.Apply(dom);

                html.Children.Add(dom);
            }
        }
        
    }
}

