namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheet settings.
    /// </summary>
    public class SpreadsheetSheetBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetSheet container;
        private readonly Spreadsheet spreadsheet;

        public SpreadsheetSheetBuilder(SpreadsheetSheet settings, Spreadsheet widget)
        {
            container = settings;
            spreadsheet = widget;
        }

        //>> Fields
        
        /// <summary>
        /// The active cell in the sheet, e.g. "A1".
        /// </summary>
        /// <param name="value">The value that configures the activecell.</param>
        public SpreadsheetSheetBuilder ActiveCell(string value)
        {
            container.ActiveCell = value;

            return this;
        }
        
        /// <summary>
        /// The name of the sheet.
        /// </summary>
        /// <param name="value">The value that configures the name.</param>
        public SpreadsheetSheetBuilder Name(string value)
        {
            container.Name = value;

            return this;
        }
        
        /// <summary>
        /// An array defining the columns in this sheet and their content.
        /// </summary>
        /// <param name="configurator">The action that configures the columns.</param>
        public SpreadsheetSheetBuilder Columns(Action<SpreadsheetSheetColumnFactory> configurator)
        {
            configurator(new SpreadsheetSheetColumnFactory(container.Columns));
            return this;
        }
        
        /// <summary>
        /// Defines the filtering criteria for this sheet, if any.
        /// </summary>
        /// <param name="configurator">The action that configures the filter.</param>
        public SpreadsheetSheetBuilder Filter(Action<SpreadsheetSheetFilterSettingsBuilder> configurator)
        {
            configurator(new SpreadsheetSheetFilterSettingsBuilder(container.Filter));
            return this;
        }
        
        /// <summary>
        /// The number of frozen columns in this sheet.
        /// </summary>
        /// <param name="value">The value that configures the frozencolumns.</param>
        public SpreadsheetSheetBuilder FrozenColumns(int value)
        {
            container.FrozenColumns = value;

            return this;
        }
        
        /// <summary>
        /// The number of frozen rows in this sheet.
        /// </summary>
        /// <param name="value">The value that configures the frozenrows.</param>
        public SpreadsheetSheetBuilder FrozenRows(int value)
        {
            container.FrozenRows = value;

            return this;
        }
        
        /// <summary>
        /// An array of merged cell ranges, e.g. "B1:D2".
        /// </summary>
        /// <param name="value">The value that configures the mergedcells.</param>
        public SpreadsheetSheetBuilder MergedCells(params string[] value)
        {
            container.MergedCells = value;

            return this;
        }
        
        /// <summary>
        /// The row data for this sheet.
        /// </summary>
        /// <param name="configurator">The action that configures the rows.</param>
        public SpreadsheetSheetBuilder Rows(Action<SpreadsheetSheetRowFactory> configurator)
        {
            configurator(new SpreadsheetSheetRowFactory(container.Rows));
            return this;
        }
        
        /// <summary>
        /// The selected range in the sheet, e.g. "A1:B10".
        /// </summary>
        /// <param name="value">The value that configures the selection.</param>
        public SpreadsheetSheetBuilder Selection(string value)
        {
            container.Selection = value;

            return this;
        }
        
        /// <summary>
        /// A boolean value indicating if the sheet grid lines should be displayed.
        /// </summary>
        /// <param name="value">The value that configures the showgridlines.</param>
        public SpreadsheetSheetBuilder ShowGridLines(bool value)
        {
            container.ShowGridLines = value;

            return this;
        }
        
        /// <summary>
        /// Defines the sort criteria for the sheet.
        /// </summary>
        /// <param name="configurator">The action that configures the sort.</param>
        public SpreadsheetSheetBuilder Sort(Action<SpreadsheetSheetSortSettingsBuilder> configurator)
        {
            configurator(new SpreadsheetSheetSortSettingsBuilder(container.Sort));
            return this;
        }
        
        //<< Fields

        /// <summary>
        /// Sets the data source configuration of the grid.
        /// </summary>
        /// <param name="configurator">The lambda which configures the data source</param>
        public SpreadsheetSheetBuilder DataSource<T>(Action<DataSourceBuilder<T>> configurator)
            where T : class
        {
            container.DataSource = new DataSource()
            {
                Type = DataSourceType.Ajax
            };

            container.DataSource.ModelType(typeof(T));
            configurator(new DataSourceBuilder<T>(container.DataSource, spreadsheet.ViewContext, spreadsheet.UrlGenerator));

            return this;
        }
    }
}

