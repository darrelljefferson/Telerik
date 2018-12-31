namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetPdfMarginSettings settings.
    /// </summary>
    public class SpreadsheetPdfMarginSettingsBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetPdfMarginSettings container;

        public SpreadsheetPdfMarginSettingsBuilder(SpreadsheetPdfMarginSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The bottom margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value that configures the bottom.</param>
        public SpreadsheetPdfMarginSettingsBuilder Bottom(double value)
        {
            container.Bottom = value;

            return this;
        }
        
        /// <summary>
        /// The left margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value that configures the left.</param>
        public SpreadsheetPdfMarginSettingsBuilder Left(double value)
        {
            container.Left = value;

            return this;
        }
        
        /// <summary>
        /// The right margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value that configures the right.</param>
        public SpreadsheetPdfMarginSettingsBuilder Right(double value)
        {
            container.Right = value;

            return this;
        }
        
        /// <summary>
        /// The top margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value that configures the top.</param>
        public SpreadsheetPdfMarginSettingsBuilder Top(double value)
        {
            container.Top = value;

            return this;
        }
        
        //<< Fields
    }
}

