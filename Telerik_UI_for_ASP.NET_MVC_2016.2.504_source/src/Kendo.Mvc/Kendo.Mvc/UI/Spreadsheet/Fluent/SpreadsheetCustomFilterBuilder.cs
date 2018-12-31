namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumn settings.
    /// </summary>
    public class SpreadsheetCustomFilterBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetFilterSettingsColumn container;

        public SpreadsheetCustomFilterBuilder(SpreadsheetSheetFilterSettingsColumn settings)
        {
            container = settings;
        }     
        
        /// <summary>
        /// An array of filter criteria for custom filters.
        /// </summary>
        /// <param name="configurator">The action that configures the criteria.</param>
        public SpreadsheetCustomFilterBuilder Criteria(Action<SpreadsheetSheetFilterSettingsColumnCriteriaFactory> configurator)
        {
            configurator(new SpreadsheetSheetFilterSettingsColumnCriteriaFactory(container.Criteria));
            return this;
        }              
        
        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetCustomFilterBuilder Index(double value)
        {
            container.Index = value;

            return this;
        }
        
        /// <summary>
        /// The logical operator to apply to filter criteria.Possible values are and, or.
        /// </summary>
        /// <param name="value">The value that configures the logic.</param>
        public SpreadsheetCustomFilterBuilder Logic(SpreadsheetFilterLogic value)
        {
            container.Logic = value.ToString().ToLower();

            return this;
        }                      
    }
}

