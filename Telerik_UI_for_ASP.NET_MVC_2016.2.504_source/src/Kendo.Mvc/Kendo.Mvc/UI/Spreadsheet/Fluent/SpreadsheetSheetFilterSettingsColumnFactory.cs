namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Filter for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetFilterSettingsColumnFactory : IHideObjectMembers
    {
        private readonly List<SpreadsheetSheetFilterSettingsColumn> container;

        public SpreadsheetSheetFilterSettingsColumnFactory(List<SpreadsheetSheetFilterSettingsColumn> container)
        {
            this.container = container;
        }        
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory ValueFilter(Action<SpreadsheetValueFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "value"
            };

            container.Add(item);

            configuration(new SpreadsheetValueFilterBuilder(item));

            return this;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory TopFilter(Action<SpreadsheetTopFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "top"
            };

            container.Add(item);

            configuration(new SpreadsheetTopFilterBuilder(item));

            return this;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory DynamicFilter(Action<SpreadsheetDynamicFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "dynamic"
            };

            container.Add(item);

            configuration(new SpreadsheetDynamicFilterBuilder(item));

            return this;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory CustomFilter(Action<SpreadsheetCustomFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "custom"
            };

            container.Add(item);

            configuration(new SpreadsheetCustomFilterBuilder(item));

            return this;
        }     
    }
}

