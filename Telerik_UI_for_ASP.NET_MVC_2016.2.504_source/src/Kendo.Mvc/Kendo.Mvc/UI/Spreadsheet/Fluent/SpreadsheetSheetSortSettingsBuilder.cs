namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetSortSettings settings.
    /// </summary>
    public class SpreadsheetSheetSortSettingsBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetSortSettings container;

        public SpreadsheetSheetSortSettingsBuilder(SpreadsheetSheetSortSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Specifies the sort options for individual columns.
        /// </summary>
        /// <param name="configurator">The action that configures the columns.</param>
        public SpreadsheetSheetSortSettingsBuilder Columns(Action<SpreadsheetSheetSortSettingsColumnFactory> configurator)
        {
            configurator(new SpreadsheetSheetSortSettingsColumnFactory(container.Columns));
            return this;
        }
        
        /// <summary>
        /// The sorted range, e.g. "A1:D5".
        /// </summary>
        /// <param name="value">The value that configures the ref.</param>
        public SpreadsheetSheetSortSettingsBuilder Ref(string value)
        {
            container.Ref = value;

            return this;
        }
        
        //<< Fields
    }
}

