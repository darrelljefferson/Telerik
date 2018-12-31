namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetRowCell settings.
    /// </summary>
    public class SpreadsheetSheetRowCellBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheetRowCell container;

        public SpreadsheetSheetRowCellBuilder(SpreadsheetSheetRowCell settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The background color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        /// <param name="value">The value that configures the background.</param>
        public SpreadsheetSheetRowCellBuilder Background(string value)
        {
            container.Background = value;

            return this;
        }
        
        /// <summary>
        /// The font color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public SpreadsheetSheetRowCellBuilder Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        /// <summary>
        /// The font family for the cell.
        /// </summary>
        /// <param name="value">The value that configures the fontfamily.</param>
        public SpreadsheetSheetRowCellBuilder FontFamily(string value)
        {
            container.FontFamily = value;

            return this;
        }
        
        /// <summary>
        /// The font size of the cell in pixels.
        /// </summary>
        /// <param name="value">The value that configures the fontsize.</param>
        public SpreadsheetSheetRowCellBuilder FontSize(double value)
        {
            container.FontSize = value;

            return this;
        }
        
        /// <summary>
        /// Sets the cell font to italic, if set to true.
        /// </summary>
        /// <param name="value">The value that configures the italic.</param>
        public SpreadsheetSheetRowCellBuilder Italic(bool value)
        {
            container.Italic = value;

            return this;
        }
        
        /// <summary>
        /// Sets the cell font to bold, if set to true.
        /// </summary>
        /// <param name="value">The value that configures the bold.</param>
        public SpreadsheetSheetRowCellBuilder Bold(bool value)
        {
            container.Bold = value;

            return this;
        }
        
        /// <summary>
        /// Disables the cell, if set to false.
        /// </summary>
        /// <param name="value">The value that configures the enable.</param>
        public SpreadsheetSheetRowCellBuilder Enable(bool value)
        {
            container.Enable = value;

            return this;
        }
        
        /// <summary>
        /// The format of the cell text.See Create or delete a custom number format on MS Office.
        /// </summary>
        /// <param name="value">The value that configures the format.</param>
        public SpreadsheetSheetRowCellBuilder Format(string value)
        {
            container.Format = value;

            return this;
        }
        
        /// <summary>
        /// The cell formula without the leading equals sign, e.g. A1 * 10.
        /// </summary>
        /// <param name="value">The value that configures the formula.</param>
        public SpreadsheetSheetRowCellBuilder Formula(string value)
        {
            container.Formula = value;

            return this;
        }
        
        /// <summary>
        /// The zero-based index of the cell. Required to ensure correct positioning.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetSheetRowCellBuilder Index(int value)
        {
            container.Index = value;

            return this;
        }
        
        /// <summary>
        /// The hyperlink (URL) of the cell.
        /// </summary>
        /// <param name="value">The value that configures the link.</param>
        public SpreadsheetSheetRowCellBuilder Link(string value)
        {
            container.Link = value;

            return this;
        }
        
        /// <summary>
        /// Sets the cell font to underline, if set to true.
        /// </summary>
        /// <param name="value">The value that configures the underline.</param>
        public SpreadsheetSheetRowCellBuilder Underline(bool value)
        {
            container.Underline = value;

            return this;
        }
        
        /// <summary>
        /// The validation rule applied to the cell.
        /// </summary>
        /// <param name="configurator">The action that configures the validation.</param>
        public SpreadsheetSheetRowCellBuilder Validation(Action<SpreadsheetSheetRowCellValidationSettingsBuilder> configurator)
        {
            configurator(new SpreadsheetSheetRowCellValidationSettingsBuilder(container.Validation));
            return this;
        }
        
        /// <summary>
        /// Will wrap the cell content if set to true.
        /// </summary>
        /// <param name="value">The value that configures the wrap.</param>
        public SpreadsheetSheetRowCellBuilder Wrap(bool value)
        {
            container.Wrap = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the text alignment in the cell
        /// </summary>
        /// <param name="value">The value that configures the textalign.</param>
        public SpreadsheetSheetRowCellBuilder TextAlign(SpreadsheetTextAlign value)
        {
            container.TextAlign = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the text vertical alignment in the cell
        /// </summary>
        /// <param name="value">The value that configures the verticalalign.</param>
        public SpreadsheetSheetRowCellBuilder VerticalAlign(SpreadsheetVerticalAlign value)
        {
            container.VerticalAlign = value;

            return this;
        }
        
        //<< Fields

        /// <summary>
        /// Configures the value for the cell
        /// </summary>
        /// <param name="value">The cell value.</param>
        public SpreadsheetSheetRowCellBuilder Value(object value)
        {
            container.Value = value;

            return this;
        }

        /// <summary>
        /// Configure bottom border.
        /// </summary>
        /// <param name="action">The value that configures the border.</param>        
        public SpreadsheetSheetRowCellBuilder BorderBottom(Action<SpreadsheetBorderStyleBuilder> action)
        {
            action(new SpreadsheetBorderStyleBuilder(container.BorderBottom));

            return this;
        }

        /// <summary>
        /// Configure top border.
        /// </summary>
        /// <param name="action">The value that configures the border.</param>        
        public SpreadsheetSheetRowCellBuilder BorderTop(Action<SpreadsheetBorderStyleBuilder> action)
        {
            action(new SpreadsheetBorderStyleBuilder(container.BorderTop));

            return this;
        }

        /// <summary>
        /// Configure left border.
        /// </summary>
        /// <param name="action">The value that configures the border.</param>        
        public SpreadsheetSheetRowCellBuilder BorderLeft(Action<SpreadsheetBorderStyleBuilder> action)
        {
            action(new SpreadsheetBorderStyleBuilder(container.BorderLeft));

            return this;
        }

        /// <summary>
        /// Configure right border.
        /// </summary>
        /// <param name="action">The value that configures the border.</param>        
        public SpreadsheetSheetRowCellBuilder BorderRight(Action<SpreadsheetBorderStyleBuilder> action)
        {
            action(new SpreadsheetBorderStyleBuilder(container.BorderRight));

            return this;
        }
    }
}

