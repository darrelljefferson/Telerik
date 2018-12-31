namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumnCriteria settings.
    /// </summary>
    public class SpreadsheetSheetFilterSettingsColumnCriteriaBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetFilterSettingsColumnCriteria container;
        private static readonly Dictionary<SpreadsheetFilterOperator, string> operators = new Dictionary<SpreadsheetFilterOperator, string>
        {
            { SpreadsheetFilterOperator.Contains, "contains" },
            { SpreadsheetFilterOperator.DoesNotContain, "doesnotcontain" },
            { SpreadsheetFilterOperator.StartsWith, "startswith" },
            { SpreadsheetFilterOperator.EndsWith, "endswith" },
            { SpreadsheetFilterOperator.EqualTo, "eq" },
            { SpreadsheetFilterOperator.NotEqualTo, "neq" },
            { SpreadsheetFilterOperator.LowerThan, "lt" },
            { SpreadsheetFilterOperator.GreaterThan, "gt" },
            { SpreadsheetFilterOperator.GreaterThanOrEqualTo, "gte" },
            { SpreadsheetFilterOperator.LowerThanOrEqualTo, "lte" }   
        };

        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder(SpreadsheetSheetFilterSettingsColumnCriteria settings)
        {
            container = settings;
        }
        
        /// <summary>
        /// The criterion operator type.Supported types vary based on the inferred column data type (inferred):
		/// * Text
		///     * contains - the text contains the value
		///     * doesnotcontain - text does not contain the value
		///     * startswith - text starts with the value
		///     * endswith - text ends with the value
		/// * Date
		///     * eq -  date is the same as the value
		///     * neq - date is not the same as the value
		///     * lt -  date is before the value
		///     * gt -  date is after the value
		/// * Number
		///     * eq - is equal to the value
		///     * neq - is not equal to the value
		///     * gte - is greater than or equal to the value
		///     * gt - is greater than the value
		///     * lte - is less than or equal to the value
		///     * lt - is less than the value
        /// </summary>
        /// <param name="value">The value that configures the operator.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Operator(SpreadsheetFilterOperator value)
        {
            container.Operator = operators[value];

            return this;
        }
        
        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(string value)
        {
            container.Value = value;

            return this;
        }

        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(DateTime value)
        {
            container.Value = value;

            return this;
        }

        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(double value)
        {
            container.Value = value;

            return this;
        }        
    }
}

