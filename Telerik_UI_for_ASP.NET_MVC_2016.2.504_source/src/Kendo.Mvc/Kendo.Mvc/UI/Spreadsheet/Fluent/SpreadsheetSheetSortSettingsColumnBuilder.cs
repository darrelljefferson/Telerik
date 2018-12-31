namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetSortSettingsColumn settings.
    /// </summary>
    public class SpreadsheetSheetSortSettingsColumnBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetSortSettingsColumn container;

        public SpreadsheetSheetSortSettingsColumnBuilder(SpreadsheetSheetSortSettingsColumn settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Indicates if the data in the cell should be sorted ascending (true) or descending or (false).
        /// </summary>
        /// <param name="value">The value that configures the ascending.</param>
        public SpreadsheetSheetSortSettingsColumnBuilder Ascending(bool value)
        {
            container.Ascending = value;

            return this;
        }
        
        /// <summary>
        /// The index of the column within the sheet.For example, column C will have index 2.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetSheetSortSettingsColumnBuilder Index(double value)
        {
            container.Index = value;

            return this;
        }
        
        //<< Fields
    }
}

