namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetHtmlBuilder
    {
        private readonly Spreadsheet component;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetHtmlBuilder" /> class.
        /// </summary>
        /// <param name="component">The Spreadsheet component.</param>
        public SpreadsheetHtmlBuilder(Spreadsheet component)
        {
            this.component = component;
        }

        /// <summary>
        /// Builds the Spreadsheet markup.
        /// </summary>
        /// <returns></returns>
        public IHtmlNode Build()
        {
            var html = CreateElement();
            html.Attribute("data-role", "spreadsheet")
                .Attribute("id", component.Id)
                .Attributes(this.component.HtmlAttributes);

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

