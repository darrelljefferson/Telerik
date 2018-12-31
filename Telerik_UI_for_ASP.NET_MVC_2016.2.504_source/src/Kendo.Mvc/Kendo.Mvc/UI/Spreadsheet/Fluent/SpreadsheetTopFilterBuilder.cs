namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumn settings.
    /// </summary>
    public class SpreadsheetTopFilterBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetFilterSettingsColumn container;

        public SpreadsheetTopFilterBuilder(SpreadsheetSheetFilterSettingsColumn settings)
        {
            container = settings;
        }        
               
        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetTopFilterBuilder Index(double value)
        {
            container.Index = value;

            return this;
        }               
        
        /// <summary>
        /// The filter sub-type, if any.Applicable types according to the main filter.		
		///     * topNumber
		///     * topPercent
		///     * bottomNumber
		///     * bottomPercent	
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public SpreadsheetTopFilterBuilder Type(SpreadsheetTopFilterType value)
        {
            container.Type = value.ToString().ToCamelCase();

            return this;
        }
        
        /// <summary>
        /// The filter value for filters that require a single value, e.g. "top".
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetTopFilterBuilder Value(double value)
        {
            container.Value = value;

            return this;
        }              
    }
}

