namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Sheet for ASP.NET MVC
    /// </summary>
    public class SpreadsheetSheetColumnFactory : IHideObjectMembers
    {
        private readonly List<SpreadsheetSheetColumn> container;

        public SpreadsheetSheetColumnFactory(List<SpreadsheetSheetColumn> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetColumnBuilder Add()
        {
            var item = new SpreadsheetSheetColumn();

            container.Add(item);

            return new SpreadsheetSheetColumnBuilder(item);
        }
        //<< Factory methods
    }
}

