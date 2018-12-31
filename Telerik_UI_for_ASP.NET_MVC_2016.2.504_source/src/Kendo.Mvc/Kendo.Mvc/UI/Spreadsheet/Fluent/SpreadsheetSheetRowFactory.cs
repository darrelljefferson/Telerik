namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Sheet for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetRowFactory : IHideObjectMembers
    {
        private readonly List<SpreadsheetSheetRow> container;

        public SpreadsheetSheetRowFactory(List<SpreadsheetSheetRow> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetRowBuilder Add()
        {
            var item = new SpreadsheetSheetRow();

            container.Add(item);

            return new SpreadsheetSheetRowBuilder(item);
        }
        //<< Factory methods
    }
}

