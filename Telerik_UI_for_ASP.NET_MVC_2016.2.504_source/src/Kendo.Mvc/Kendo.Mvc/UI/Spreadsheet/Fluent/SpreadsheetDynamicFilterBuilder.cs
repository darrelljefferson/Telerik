namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumn settings.
    /// </summary>
    public class SpreadsheetDynamicFilterBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetFilterSettingsColumn container;

        public SpreadsheetDynamicFilterBuilder(SpreadsheetSheetFilterSettingsColumn settings)
        {
            container = settings;
        }               
        
        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetDynamicFilterBuilder Index(double value)
        {
            container.Index = value;

            return this;
        }
              
        /// <summary>
        /// The filter sub-type, if any.Applicable types according to the main filter.		
		///     * aboveAverage
		///     * belowAverage
		///     * tomorrow
		///     * today
		///     * yesterday
		///     * nextWeek
		///     * thisWeek
		///     * lastWeek
		///     * nextMonth
		///     * thisMonth
		///     * lastMonth
		///     * nextQuarter
		///     * thisQuarter
		///     * lastQuarter
		///     * nextYear
		///     * thisYear
		///     * lastYear
		///     * yearToDate
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public SpreadsheetDynamicFilterBuilder Type(SpreadsheetDynamicFilterType value)
        {
            container.Type = value.ToString().ToCamelCase();

            return this;
        }               
    }
}

