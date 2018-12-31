namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetColumn settings.
    /// </summary>
    public class SpreadsheetSheetColumnBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetColumn container;

        public SpreadsheetSheetColumnBuilder(SpreadsheetSheetColumn settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The zero-based index of the column. Required to ensure correct positioning.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetSheetColumnBuilder Index(int value)
        {
            container.Index = value;

            return this;
        }
        
        /// <summary>
        /// The width of the column in pixels. Defaults to columnWidth.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public SpreadsheetSheetColumnBuilder Width(double value)
        {
            container.Width = value;

            return this;
        }
        
        //<< Fields
    }
}

