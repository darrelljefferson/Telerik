namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Spreadsheet for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetFactory : IHideObjectMembers
    {
        private readonly Spreadsheet container;

        public SpreadsheetSheetFactory(Spreadsheet container)
        {
            this.container = container;
        }

        //>> Factory methods
        //<< Factory methods

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetBuilder Add()
        {
            var item = new SpreadsheetSheet();

            container.Sheets.Add(item);

            return new SpreadsheetSheetBuilder(item, container);
        }
    }
}

