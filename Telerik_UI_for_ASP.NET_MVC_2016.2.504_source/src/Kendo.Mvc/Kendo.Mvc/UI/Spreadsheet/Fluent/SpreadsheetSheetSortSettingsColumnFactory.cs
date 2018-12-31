namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Sort for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetSortSettingsColumnFactory : IHideObjectMembers
    {
        private readonly List<SpreadsheetSheetSortSettingsColumn> container;

        public SpreadsheetSheetSortSettingsColumnFactory(List<SpreadsheetSheetSortSettingsColumn> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetSortSettingsColumnBuilder Add()
        {
            var item = new SpreadsheetSheetSortSettingsColumn();

            container.Add(item);

            return new SpreadsheetSheetSortSettingsColumnBuilder(item);
        }
        //<< Factory methods
    }
}

