namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;
using System;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Column for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetFilterSettingsColumnCriteriaFactory : IHideObjectMembers
    {
        private readonly List<SpreadsheetSheetFilterSettingsColumnCriteria> container;

        public SpreadsheetSheetFilterSettingsColumnCriteriaFactory(List<SpreadsheetSheetFilterSettingsColumnCriteria> container)
        {
            this.container = container;
        }        
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnCriteriaFactory Add(Action<SpreadsheetSheetFilterSettingsColumnCriteriaBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumnCriteria();

            container.Add(item);

            configuration(new SpreadsheetSheetFilterSettingsColumnCriteriaBuilder(item));

            return this;
        }        
    }
}

