namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumn settings.
    /// </summary>
    public class SpreadsheetValueFilterBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetFilterSettingsColumn container;

        public SpreadsheetValueFilterBuilder(SpreadsheetSheetFilterSettingsColumn settings)
        {
            container = settings;
        }        
                
        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetValueFilterBuilder Index(double value)
        {
            container.Index = value;

            return this;
        }                     
        
        /// <summary>
        /// The filter values for filters that support multiple values.
        /// </summary>
        /// <param name="value">The value that configures the values.</param>
        public SpreadsheetValueFilterBuilder Values(params object[] value)
        {
            container.Values = value;

            return this;
        }
    }
}

