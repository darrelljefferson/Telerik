namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Row for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetRowCellFactory : IHideObjectMembers
    {
        private readonly List<SpreadsheetSheetRowCell> container;

        public SpreadsheetSheetRowCellFactory(List<SpreadsheetSheetRowCell> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetRowCellBuilder Add()
        {
            var item = new SpreadsheetSheetRowCell();

            container.Add(item);

            return new SpreadsheetSheetRowCellBuilder(item);
        }
        //<< Factory methods
    }
}

