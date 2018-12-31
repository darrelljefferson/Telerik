namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;

    public class ResponsivePanelHtmlBuilder
    {
        private readonly ResponsivePanel component;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsivePanelHtmlBuilder" /> class.
        /// </summary>
        /// <param name="component">The ResponsivePanel component.</param>
        public ResponsivePanelHtmlBuilder(ResponsivePanel component)
        {
            this.component = component;
        }

        /// <summary>
        /// Builds the ResponsivePanel markup.
        /// </summary>
        /// <returns></returns>
        public IHtmlNode Build()
        {
            var html = CreateElement();
            html.Attribute("data-role", "responsivepanel")
                .Attribute("id", component.Id);

            if (component.Template.HasValue())
            {
                component.Template.Apply(html);
            }

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
        
    }
}

