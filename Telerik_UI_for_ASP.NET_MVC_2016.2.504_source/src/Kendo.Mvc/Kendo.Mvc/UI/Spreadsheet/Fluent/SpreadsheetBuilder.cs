namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo Spreadsheet for ASP.NET MVC.
    /// </summary>
    public class SpreadsheetBuilder: WidgetBuilderBase<Spreadsheet, SpreadsheetBuilder>
    {
        private readonly Spreadsheet container;
        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public SpreadsheetBuilder(Spreadsheet component)
            : base(component)
        {
            container = component;
        }

        //>> Fields
        
        /// <summary>
        /// The name of the currently active sheet.Must match one of the (sheet names)[#configuration-sheets.name] exactly.
        /// </summary>
        /// <param name="value">The value that configures the activesheet.</param>
        public SpreadsheetBuilder ActiveSheet(string value)
        {
            container.ActiveSheet = value;

            return this;
        }
        
        /// <summary>
        /// The default column width in pixels.
        /// </summary>
        /// <param name="value">The value that configures the columnwidth.</param>
        public SpreadsheetBuilder ColumnWidth(double value)
        {
            container.ColumnWidth = value;

            return this;
        }
        
        /// <summary>
        /// The number of columns in the document.
        /// </summary>
        /// <param name="value">The value that configures the columns.</param>
        public SpreadsheetBuilder Columns(double value)
        {
            container.Columns = value;

            return this;
        }
        
        /// <summary>
        /// The height of the header row in pixels.
        /// </summary>
        /// <param name="value">The value that configures the headerheight.</param>
        public SpreadsheetBuilder HeaderHeight(double value)
        {
            container.HeaderHeight = value;

            return this;
        }
        
        /// <summary>
        /// The width of the header column in pixels.
        /// </summary>
        /// <param name="value">The value that configures the headerwidth.</param>
        public SpreadsheetBuilder HeaderWidth(double value)
        {
            container.HeaderWidth = value;

            return this;
        }
        
        /// <summary>
        /// Configures the Kendo UI Spreadsheet Excel export settings.
        /// </summary>
        /// <param name="configurator">The action that configures the excel.</param>
        public SpreadsheetBuilder Excel(Action<SpreadsheetExcelSettingsBuilder> configurator)
        {
            configurator(new SpreadsheetExcelSettingsBuilder(container.Excel));
            return this;
        }
        
        /// <summary>
        /// Configures the Kendo UI Spreadsheet PDF export settings.
        /// </summary>
        /// <param name="configurator">The action that configures the pdf.</param>
        public SpreadsheetBuilder Pdf(Action<SpreadsheetPdfSettingsBuilder> configurator)
        {
            configurator(new SpreadsheetPdfSettingsBuilder(container.Pdf));
            return this;
        }
        
        /// <summary>
        /// The default row height in pixels.
        /// </summary>
        /// <param name="value">The value that configures the rowheight.</param>
        public SpreadsheetBuilder RowHeight(double value)
        {
            container.RowHeight = value;

            return this;
        }
        
        /// <summary>
        /// The number of rows in the document.
        /// </summary>
        /// <param name="value">The value that configures the rows.</param>
        public SpreadsheetBuilder Rows(double value)
        {
            container.Rows = value;

            return this;
        }
        
        /// <summary>
        /// A boolean value indicating if the sheetsbar should be displayed.
        /// </summary>
        /// <param name="value">The value that configures the sheetsbar.</param>
        public SpreadsheetBuilder Sheetsbar(bool value)
        {
            container.Sheetsbar = value;

            return this;
        }
        

        /// <summary>
        /// A boolean value indicating if the toolbar should be displayed.
        /// </summary>
        /// <param name="enabled">Enables or disables the toolbar option.</param>
        public SpreadsheetBuilder Toolbar(bool enabled)
        {
            container.Toolbar.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// A boolean value indicating if the toolbar should be displayed.
        /// </summary>
        /// <param name="configurator">The action that configures the toolbar.</param>
        public SpreadsheetBuilder Toolbar(Action<SpreadsheetToolbarSettingsBuilder> configurator)
        {
            container.Toolbar.Enabled = true;
            
            configurator(new SpreadsheetToolbarSettingsBuilder(container.Toolbar));
            return this;
        }
        
        //<< Fields

        public SpreadsheetBuilder BindTo(IEnumerable<SpreadsheetSheet> value)
        {
            container.Sheets.Clear();
            container.Sheets.AddRange(value);

            return this;
        }

        public SpreadsheetBuilder BindTo(Dictionary<string, object> workbook)
        {
            container.DplSettings = workbook;

            return this;
        }

        /// <summary>
        /// An array defining the document sheets and their content.
        /// </summary>
        /// <param name="configurator">The action that configures the sheets.</param>
        public SpreadsheetBuilder Sheets(Action<SpreadsheetSheetFactory> configurator)
        {
            configurator(new SpreadsheetSheetFactory(container));
            return this;
        }

        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Spreadsheet()
        ///             .Name("Spreadsheet")
        ///             .Events(events => events
        ///                 .Render("onRender")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public SpreadsheetBuilder Events(Action<SpreadsheetEventBuilder> configurator)
        {

            configurator(new SpreadsheetEventBuilder(Component.Events));

            return this;
        }
        
    }
}

